﻿using System;
using System.Numerics;
using System.Threading.Tasks;

namespace FractalsConsole
{
    internal class Fractal
    {
        private int PixelsMatrixWidth;
        private int PixelsMatrixHeight;
        public byte[,] PixelsMatrix;
        public Complex[,] ComplexMatrix;
        //private Complex Seed;
        byte max_iteration;

        // Limits
        public double LeftLimit;
        public double RightLimit;
        public double UpLimit;
        public double DownLimit;

        // To convert from pixels to complex
        double hRatio;
        double wRatio;

        double wOffset;
        double hOffset;

        //// Converted
        //double xComplex;
        //double yComplex;

        //// Iteration
        //double x0, y0;

        //double x2 = 0;
        //double y2 = 0;

        //double x = 0;
        //double y = 0;

        //byte iteration = 0x00;

        int ii = 0;
        int jj = 0;

        public int Width { get; }
        public int Height { get; }

        public Fractal(int width, int height, double LeftLimit, double RightLimit, double DownLimit, double UpLimit, int max_iteration = 256)
        {
            this.Width = width;
            this.Height= width;
            this.LeftLimit = LeftLimit;
            this.RightLimit = RightLimit;
            this.UpLimit = UpLimit;
            this.DownLimit = DownLimit;

            this.PixelsMatrixWidth = width;
            this.PixelsMatrixHeight = height;
            if (max_iteration > 0)
            {
                this.max_iteration = (byte)(max_iteration - 1);
            }
            else
            {
                this.max_iteration = (byte)max_iteration;
            }

            double ComplexWidth = (RightLimit - LeftLimit);
            double ComplexHeight = (UpLimit - DownLimit);

            hRatio = ComplexHeight / (PixelsMatrixHeight - 1);
            wRatio = ComplexWidth / (PixelsMatrixWidth - 1);

            wOffset = LeftLimit;
            hOffset = DownLimit;

            PixelsMatrix = new byte[height, width];
            ComplexMatrix = new Complex[height, width];

            // Parsing pixels
            //for (ii = 0; ii < height; ii++)
            Parallel.For(0, height, (i, state) =>
            //for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                //for (int j = width-1; j > -1; j--)
                {
                    //PixelsMatrix[i, j] = Iterations(i, j);
                    PixelsMatrix[i, j] = Iterations(i, height - 1 - i, j);
                }
            }
            );

        }

        public (double, double) ConvertPixelToComplex(int xPixel, int yPixel)
        {
            // Converted
            double xComplex;
            double yComplex;

            xComplex = xPixel * wRatio + wOffset;
            yComplex = yPixel * hRatio + hOffset;

            return (xComplex, yComplex);
        }

        //https://en.wikipedia.org/wiki/Plotting_algorithms_for_the_Mandelbrot_set#Optimized_escape_time_algorithms
        //private byte Iterations(int xPixel, int yPixel)
        // LeftLimit = -0.2 .
        // RightLimit = 0.47
        // DownLimit = -1.12 .
        // UpLimit = 1.12
        private byte Iterations(int yPixel, int yPixelReverted, int xPixel)
        {
            // Iteration
            double x0, y0;

            double x2 = 0;
            double y2 = 0;

            double x = 0;
            double y = 0;

            byte iteration = 0x00;

            (x0, y0) = ConvertPixelToComplex(xPixel, yPixelReverted);

            // Debug
            //ComplexMatrix[yPixel, xPixel] = new Complex(y0, x0);

            //x2 = 0;
            //y2 = 0;

            //x = 0;
            //y = 0;

            //iteration = 0x00;

            while (x2 + y2 <= 4 && iteration < max_iteration)
            {
                y = 2 * x * y + y0;
                x = x2 - y2 + x0;
                x2 = x * x;
                y2 = y * y;
                iteration++;
            }

            return iteration;
        }
    }
}
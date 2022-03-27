using BitmapWritter;
using FractalsConsole;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalWinForm
{
    public partial class Form1 : Form
    {
        Fractal fract;

        Bitmap8bits256Colors image;
        public Form1()
        {
            InitializeComponent();

            //
            int width = 2000 / 10;
            int height = 1500 / 10;


            fract = new Fractal(width, height, -2, 0.47, -1.12, 1.12);

            image = new Bitmap8bits256Colors(fract.PixelsMatrix, 150, 0, 0);
            //image.Write("TestBitmap.bmp");
            //pictureBox1.Image = Bitmap.FromFile(@"C:\Users\VFlotron\source\repos\FractalsConsole\FractalsConsole\bin\Debug\TestBitmap.bmp");
            MemoryStream stream = image.StartWritingInMemory();
            pictureBox1.Image = Bitmap.FromStream(stream);
            image.EndWritingInMemory(stream);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.W:
                    GoUp();
                    break;
                case Keys.A:
                    GoLeft();
                    break;
                case Keys.S:
                    GoDown();
                    break;
                case Keys.D:
                    GoRight();
                    break;
                case Keys.Up:
                    Zoom();
                    break;
                case Keys.Down:
                    UnZoom();
                    break;


                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            return true;
        }

        private void Recompute(int width, int height, double LeftLimit, double RightLimit, double DownLimit, double UpLimit)
        {
            fract = new Fractal(width, height, LeftLimit, RightLimit, DownLimit, UpLimit);
            UpdatePosition();
            image = new Bitmap8bits256Colors(fract.PixelsMatrix, 150, 0, 0);
            MemoryStream stream = image.StartWritingInMemory();
            pictureBox1.Image = Bitmap.FromStream(stream);
            image.EndWritingInMemory(stream);
        }

        private void UpdatePosition()
        {
            tbUp.Text = fract.UpLimit.ToString();
            tbDown.Text = fract.DownLimit.ToString();
            tbLeft.Text = fract.LeftLimit.ToString();
            tbRight.Text = fract.RightLimit.ToString();
        }

        private void btZoom_Click(object sender, EventArgs e)
        {
            Zoom();
        }
        private void Zoom()
        {
            double fact = double.Parse(tbZoomFactor.Text);

            // Calculate the actual complex width and height
            double RealRange = fract.RightLimit - fract.LeftLimit;
            double ImRange = fract.UpLimit - fract.DownLimit;

            // Calculate the futur complex width and height
            double realRangeZoomed = (RealRange / fact);
            double imRangeZoomed = (ImRange / fact);

            // Calculate the offset between the old and new LeftLimit and the offset between the old and new DownLimit.
            double realOffset = (RealRange - realRangeZoomed) / 2;
            double imOffset = (ImRange - imRangeZoomed) / 2;

            // Zoom
            fract.LeftLimit = fract.LeftLimit + realOffset;
            fract.RightLimit = fract.LeftLimit + realRangeZoomed;
            fract.DownLimit = fract.DownLimit + imOffset;
            fract.UpLimit = fract.DownLimit + imRangeZoomed;

            // Calculat the new fractal and refresh display
            Recompute(fract.Width, fract.Height, fract.LeftLimit, fract.RightLimit, fract.DownLimit, fract.UpLimit);
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            GoLeft();
        }
        private void GoLeft()
        {
            // Calculate the actual complex width
            double RealRange = fract.RightLimit - fract.LeftLimit;

            double fact = double.Parse(tbMotionFactor.Text);
            fract.LeftLimit = fract.LeftLimit - RealRange / fact;
            fract.RightLimit = fract.LeftLimit + RealRange;

            Recompute(fract.Width, fract.Height, fract.LeftLimit, fract.RightLimit, fract.DownLimit, fract.UpLimit);
        }



        private void btRight_Click(object sender, EventArgs e)
        {
            GoRight();
        }
        private void GoRight()
        {
            // Calculate the actual complex width
            double RealRange = fract.RightLimit - fract.LeftLimit;

            double fact = double.Parse(tbMotionFactor.Text);
            fract.LeftLimit = fract.LeftLimit + RealRange / fact;
            fract.RightLimit = fract.LeftLimit + RealRange;

            Recompute(fract.Width, fract.Height, fract.LeftLimit, fract.RightLimit, fract.DownLimit, fract.UpLimit);
        }

        private void btUp_Click(object sender, EventArgs e)
        {
            GoUp();
        }
        private void GoUp()
        {
            // Calculate the actual complex width and height
            double ImRange = fract.UpLimit - fract.DownLimit;

            double fact = double.Parse(tbMotionFactor.Text);
            fract.DownLimit = fract.DownLimit + ImRange / fact;
            fract.UpLimit = fract.DownLimit + ImRange;

            Recompute(fract.Width, fract.Height, fract.LeftLimit, fract.RightLimit, fract.DownLimit, fract.UpLimit);
        }

        private void btDown_Click(object sender, EventArgs e)
        {
            GoDown();
        }
        private void GoDown()
        {
            // Calculate the actual complex width and height
            double ImRange = fract.UpLimit - fract.DownLimit;

            double fact = double.Parse(tbMotionFactor.Text);
            fract.DownLimit = fract.DownLimit - ImRange / fact;
            fract.UpLimit = fract.DownLimit + ImRange;

            Recompute(fract.Width, fract.Height, fract.LeftLimit, fract.RightLimit, fract.DownLimit, fract.UpLimit);
        }

        private void btUnzoom_Click(object sender, EventArgs e)
        {
            UnZoom();
        }
        private void UnZoom()
        {
            double fact = double.Parse(tbZoomFactor.Text);

            // Calculate the actual complex width and height
            double RealRange = fract.RightLimit - fract.LeftLimit;
            double ImRange = fract.UpLimit - fract.DownLimit;

            // Calculate the futur complex width and height
            double realRangeZoomed = (RealRange * fact);
            double imRangeZoomed = (ImRange * fact);

            // Calculate the offset between the old and new LeftLimit and the offset between the old and new DownLimit.
            double realOffset = (RealRange - realRangeZoomed) / 2;
            double imOffset = (ImRange - imRangeZoomed) / 2;

            // Zoom
            fract.LeftLimit = fract.LeftLimit + realOffset;
            fract.RightLimit = fract.LeftLimit + realRangeZoomed;
            fract.DownLimit = fract.DownLimit + imOffset;
            fract.UpLimit = fract.DownLimit + imRangeZoomed;

            // Calculat the new fractal and refresh display
            Recompute(fract.Width, fract.Height, fract.LeftLimit, fract.RightLimit, fract.DownLimit, fract.UpLimit);

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmapWritter
{
    class Bitmap8bits256Colors
    {
        BitmapHeader Header;
        BitmapDIBHeader DIBHeader;
        BitmapPalette Palette;
        BitmapPixelArray PixelArray;
        int Heigth;
        int Width;
        int NbColors = 256;
        byte[] fullBitmap;


        public Bitmap8bits256Colors(byte[,] pixelsArray, int redShift = 0, int greenShift = 0, int blueShift = 0)
        {
            // Get size
            Heigth = pixelsArray.GetLength(0);
            Width = pixelsArray.GetLength(1);

            // Create Bitmap sections
            PixelArray = new BitmapPixelArray(pixelsArray);
            Palette = new BitmapPalette(NbColors, redShift, greenShift, blueShift);
            Header = new BitmapHeader(BitmapHeader.Length, BitmapDIBHeader.Length, Palette.Length, PixelArray.Length);
            DIBHeader = new BitmapDIBHeader(Width, Heigth, 1920, 1080, NbColors, PixelArray.Length);

            SerializeInBytes();
        }

        private void SerializeInBytes()
        {
            byte[] headerBytes = Header.GetBytes();
            byte[] DIBHeaderBytes = DIBHeader.GetBytes();
            byte[] PaletteBytes = Palette.GetBytes();
            byte[] pixelArrayBytes = PixelArray.GetBytes();
            fullBitmap = Tools.Tools.ConcatenateArrays(headerBytes, DIBHeaderBytes, PaletteBytes, pixelArrayBytes);
        }

        public void Write(string filename = "Bitmap256.bmp")
        {
            Tools.FileManager.WriteBytes(fullBitmap, filename);
        }
        
        public MemoryStream StartWritingInMemory(string filename = "Bitmap256.bmp")
        {
            MemoryStream ms = Tools.FileManager.StartWritingBytesInMemoryStream(fullBitmap);
            return ms;
        }

        
        public void EndWritingInMemory(MemoryStream stream)
        {
            Tools.FileManager.stream.Close();
            Tools.FileManager.bw.Close();
        }

    }

    class BitmapHeader
    {
        byte[] ID,
            FileSize,
            AppSpecific1,
            AppSpecific2,
            OffsetPixelArray;
        byte[] FullHeader { get; }

        static int length = 14;

        public static int Length
        {
            get
            {
                return length;
            }
        }

        public BitmapHeader(int SizeOfHeader, int sizeOfDIBHeaderInt, int SizeOfPalette, int SizeOfBitmapPixelArray)
        {
            ID = new byte[] { (byte)'B', (byte)'M' };
            int FileSizeInt = SizeOfHeader + sizeOfDIBHeaderInt + SizeOfPalette + SizeOfBitmapPixelArray;
            FileSize = Tools.Tools.IntToBytesLittleEndian(FileSizeInt, 4);
            AppSpecific1 = new byte[] { 0x00, 0x00 };
            AppSpecific2 = new byte[] { 0x00, 0x00 };
            OffsetPixelArray = Tools.Tools.IntToBytesLittleEndian(1078, 4);
        }

        public byte[] GetBytes()
        {
            byte[] bytes = Tools.Tools.ConcatenateArrays(ID, FileSize, AppSpecific1, AppSpecific2, OffsetPixelArray);
            return bytes;
        }
    }


    class BitmapDIBHeader
    {
        byte[] SizeOfDIBHeader,
            Width,
            Height,
            NbColorPlanes,
            NbBitsPerPixel,
            CompressionMethod,
            RawBitmapImageSize,
            HResolution,
            VResolution,
            NbColorsOfPalette,
            NbImportantColors;

        static int length = 40;

        public static int Length
        {
            get
            {
                return length;
            }
        }


        public BitmapDIBHeader(int width, int heigth, int hRes, int vRes, int nbColors, int pixelArrayRawSize, int nbBitsPerPixel = 8, int compressionMethod = 0, int nbImportantsColors = 0)
        {
            SizeOfDIBHeader = Tools.Tools.IntToBytesLittleEndian(Length, 4);
            Width = Tools.Tools.IntToBytesLittleEndian(width, 4);
            Height = Tools.Tools.IntToBytesLittleEndian(heigth, 4);
            NbColorPlanes = Tools.Tools.IntToBytesLittleEndian(1, 2);
            NbBitsPerPixel = Tools.Tools.IntToBytesLittleEndian(nbBitsPerPixel, 2);
            CompressionMethod = Tools.Tools.IntToBytesLittleEndian(compressionMethod, 4);
            RawBitmapImageSize = Tools.Tools.IntToBytesLittleEndian(pixelArrayRawSize, 4);
            HResolution = Tools.Tools.IntToBytesLittleEndian(hRes, 4);
            VResolution = Tools.Tools.IntToBytesLittleEndian(vRes, 4);
            NbColorsOfPalette = Tools.Tools.IntToBytesLittleEndian(nbColors, 4);
            NbImportantColors = Tools.Tools.IntToBytesLittleEndian(0, 4);
        }

        public byte[] GetBytes()
        {
            byte[] theBytes = Tools.Tools.ConcatenateArrays(SizeOfDIBHeader, Width, Height, NbColorPlanes, NbBitsPerPixel, CompressionMethod, RawBitmapImageSize, HResolution, VResolution, NbColorsOfPalette, NbImportantColors);
            return theBytes;
        }
    }

    class Colors
    {
        public byte red,
            green,
            blue,
            padding;


        public byte[] GetBytes()
        {
            byte[] theBytes = { red, green, blue, padding };
            return theBytes;
        }
    }


    class BitmapPalette
    {
        Colors[] ColorsPalette;
        int NbColors;
        int RedShift;
        int GreenShift;
        int BlueShift;

        int length;

        public int Length
        {
            get
            {
                return length;
            }
        }

        public BitmapPalette(int nbColors, int redShift, int greenShift, int blueShift)
        {
            NbColors = nbColors;
            length = nbColors * 4;


            ColorsPalette = InitColorsPalette(nbColors);

            RedShift = redShift;
            GreenShift = greenShift;
            BlueShift = blueShift;

            InitPalette(nbColors, redShift, greenShift, blueShift);
        }

        private Colors[] InitColorsPalette(int nbColors)
        {
            ColorsPalette = new Colors[nbColors];
            for (int i = 0; i < nbColors; i++)
            {
                ColorsPalette[i] = new Colors();
            }

            return ColorsPalette;
        }

        private void InitPalette(int nbColors, int redShift, int greenShift, int blueShift)
        {
            double redIncr = ((double)nbColors - (double)redShift) / (double)nbColors;
            double greenIncr = ((double)nbColors - (double)greenShift) / (double)nbColors;
            double blueIncr = ((double)nbColors - (double)blueShift) / (double)nbColors;

            double A_r = 10;
            double alpha_r;
            double B_r = 2 * Math.PI * 0.9;
            double C_r = 0;

            double A_g = 255;
            double alpha_g;
            double B_g = 2 * Math.PI * 0.5;
            double C_g = 2;

            double A_b = 50;
            double alpha_b;
            double B_b = 2 * Math.PI * 0.9;
            double C_b = 4;

            double twoPiDivBy256 = 2 * Math.PI / 256;


            // Init color palette
            for (int i = 0; i < nbColors; i++)
            {
                alpha_r = i * twoPiDivBy256;
                alpha_g = i * twoPiDivBy256;
                alpha_b = i * twoPiDivBy256;

                ColorsPalette[i].red = (byte)(A_r * Math.Sin(alpha_r * 2 * Math.PI + B_r) + C_r);
                ColorsPalette[i].green = (byte)(A_g * Math.Sin(alpha_g * 2 * Math.PI + B_g) + C_g);
                ColorsPalette[i].blue = (byte)(A_b * Math.Sin(alpha_b * 2 * Math.PI + B_b) + C_b);
            }
        }


        public byte[] GetBytes()
        {
            byte[] theBytes = new byte[NbColors * 4];
            byte[] actualColor = new byte[4];
            for (int i = 0; i < NbColors; i++)
            {
                actualColor = ColorsPalette[i].GetBytes();
                for (int j = 0; j < 4; j++)
                {
                    theBytes[i * 4 + j] = actualColor[j];
                }
            }

            return theBytes;
        }
    }

    class BitmapPixelArray
    {
        int length;
        byte[][] PixelsValuesPadded;

        public int Length
        {
            get
            {
                return length;
            }
        }

        public BitmapPixelArray(byte[,] pixelsValues)
        {
            // Find how to padd
            int width = pixelsValues.GetLength(1);
            int height = pixelsValues.GetLength(0);

            double remain = width % 4;
            int widthDevidedBy4 = width / 4;
            int widthPadded = int.MinValue;

            if (remain == 0)
            {
                widthPadded = width;
            }
            else
            {
                // 5
                while (++widthDevidedBy4 % 4 != 0) { }
                widthPadded = widthDevidedBy4;
            }

            // Filling padded pixels array and reverse line order
            PixelsValuesPadded = new byte[height][];
            int j;
            for (int i = 0; i < height; i++)
            {
                PixelsValuesPadded[i] = new byte[widthPadded];
                // Fill rows to the width
                for (j = 0; j < width; j++)
                {
                    PixelsValuesPadded[i][j] = pixelsValues[height - i - 1,j];
                }
                // Finish fill the row by padding 0x00
                for (int k = j; k < widthPadded; k++)
                {
                    PixelsValuesPadded[i][k] = 0x00;
                }
            }
            length = widthPadded * height;
        }


        public byte[] GetBytes()
        {
            byte[] bytes = new byte[0];
            foreach (byte[] pixelRowPadded in PixelsValuesPadded)
            {
                bytes = Tools.Tools.ConcatenateArrays(bytes, pixelRowPadded);
            }
            return bytes;
        }

    }
}

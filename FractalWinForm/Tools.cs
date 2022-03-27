using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    class Tools
    {
        public static byte[] IntToBytesLittleEndian(int valueInt, int bytesArrayLength)
        {
            // Padded array
            byte[] bytesLittleEndian = new byte[bytesArrayLength];
            // Fill array with zeros (padding)
            for (int i = 0; i < bytesArrayLength; i++)
            {
                bytesLittleEndian[i] = 0x00;
            }
            // Convert int to byte
            byte[] intBytes = BitConverter.GetBytes(valueInt);

            // Copy to padded array
            //for (int i = 0; i < intBytes.Length; i++)
            ////for (int i = 0; i < bytesArrayLength; i++)
            ////{
            ////    bytesLittleEndian[i] = intBytes[i];
            ////}
            
            //return bytesLittleEndian;
            return intBytes.Take(bytesArrayLength).ToArray();
        }

        public static T[] ConcatenateArrays<T>(params T[][] inputArrays)
        {
            T[] outputArray;
            int len = 0;
            // Get the size of the outputArray
            foreach (T[] arr in inputArrays)
            {
                len += arr.Length;
            }
            // Allocate size of the outputArray
            outputArray = new T[len];

            // Concatenate the input arrays
            len = 0;
            for (int i = 0; i < inputArrays.Length; i++)
            {
                for (int j = 0; j < inputArrays[i].Length; j++)
                {
                    outputArray[len + j] = inputArrays[i][j];
                }
                len += inputArrays[i].Length;
            }

            return outputArray;
        }

        public static T[][] Array2DToArrayOfArrays<T>(T[,] pixelsValuesInit)
        {
            int height = pixelsValuesInit.GetLength(0);
            int width = pixelsValuesInit.GetLength(1);
            T[][] pixelsValues = new T[height][];
            for (int i = 0; i < height; i++)
            {
                pixelsValues[i] = new T[width];
                for (int j = 0; j < width; j++)
                {
                    pixelsValues[i][j] = pixelsValuesInit[i, j];
                }
            }

            return pixelsValues;
        }
        public static void InitNestedArray2D<T>(T[,] nestedArray, T value)
        {
            int height = nestedArray.GetLength(0);
            int width = nestedArray.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    nestedArray[i, j] = value;

                }
            }
        }

        public static void InitMatrixOfBytes2D(byte[,] nestedArray, int maxValue)
        {
            int height = nestedArray.GetLength(0);
            int width = nestedArray.GetLength(1);

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    nestedArray[i, j] = (byte)((i+j) % maxValue);
                }
            }
        }

    }
}

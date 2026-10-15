using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Matrix
    {
        private int[,] arr;

        Matrix()
        {
            arr = new int[1, 1];
            arr[0,0] = 0;
        }
        Matrix(int[,] _arr)
        {
            arr = _arr;
        }

        private int[,] Arr
        {
            set
            {
                arr = value;
            }
            get
            {
                return arr;
            }

        }

        int arrmax()
        {
            int max1 = arr[0, 0];

            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    max1 = Math.Max(arr[i, j], max1);
                }
            }
            return max1;
        }
        int arrmin()
        {
            int min1 = arr[0, 0];

            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    min1 = Math.Min(arr[i, j], min1);
                }
            }
            return min1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Vector
    {
        private int[] arr;

        Vector()
        {
            arr = new int[1];
            arr[0] = 0;
        }

        Vector(int[] _arr)
        {
            arr = _arr;
        }

        private int[] Arr
        {
            get
            {
                return arr;
            }
            set
            {
                arr = value;
            }
        }

        void add(Vector other)
        {
            if (other.Arr.Length == arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] += other.Arr[i];
                }
            }
        }
        void subst(Vector other)
        {
            if (other.Arr.Length == arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] -= other.Arr[i];
                }
            }
        }
        void mult(Vector other)
        {
            if (other.Arr.Length == arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] *= other.Arr[i];
                }
            }
        }
    }
}

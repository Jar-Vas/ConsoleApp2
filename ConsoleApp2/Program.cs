namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region t1
            Console.WriteLine("TASK1");
            long a1 = product(1, 5);
            Console.WriteLine("ans: " + a1);
            #endregion t1

            Console.WriteLine("\nTASK2");
            long num = 2585; 
            Console.WriteLine("Ans: " + isFib(num));




            #region t3
            Console.WriteLine("\nTASK3");
            Console.WriteLine("Reverse? (true or false): ");
            string t3 = Console.ReadLine();
            if (bool.TryParse(t3, out bool k3))
            {
                int[] arr = [1, 5, 6, 4, 3, 2];
                mySort(ref arr, true);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Idk wt u wnt");
            }
            #endregion t3


        }
        static long product(int a, int b)
        {
            if (a >  b) { (a, b) = (b, a); }
            long ans = 1;
            for (int i = a; i <= b; i++)
            {
                ans *= i;
            }
            return ans;
        }

        static bool isPerfectSq(long num)
        {
            long sq = (long)Math.Sqrt(num);
            return sq * sq == num;
        }

        static bool isFib(long num)
        {
            return isPerfectSq(5 * num * num + 4) || isPerfectSq(5 * num * num - 4); //cheat formula
        }

        static bool isSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        static void mySort(ref int[] arr, bool reverse)
        {
            while (!isSort(arr))
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    }
                }
            }
            if (reverse)
            {
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    (arr[i], arr[arr.Length - i - 1]) = (arr[arr.Length - i - 1], arr[i]);
                }
            }
        }





    }
}

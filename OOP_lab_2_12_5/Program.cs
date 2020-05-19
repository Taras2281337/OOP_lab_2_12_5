using System;

namespace OOP_lab_2_12_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[][] a = new int[int.Parse(elements[0])][];

            var rand = new Random();

            for (int i = 0; i < a.Length; ++i)
            {
                a[i] = new int[int.Parse(elements[1])];

                for (int j = 0; j < a[i].Length; ++j)
                {
                    a[i][j] = rand.Next(-100, 100);
                }
            }

            Console.WriteLine("\n");

            for (int i = 0; i < a.Length; ++i)
            {
                for (int j = 0; j < a[i].Length; ++j)
                {
                    Console.Write("{0, -6}", a[i][j]);
                }

                Console.WriteLine("\n");
            }

            int sum = 0;

            for (int i = 0; i < a.Length; ++i)
            {
                for (int j = 0; j < a[i].Length; ++j)
                {
                    if (a[i][j] < 0)
                    {
                        sum += a[i][j];
                    }
                }
            }

            Console.WriteLine("\n\nCумa вiд’ємних елементiв матрицi: {0}", sum);
        }
    }
}

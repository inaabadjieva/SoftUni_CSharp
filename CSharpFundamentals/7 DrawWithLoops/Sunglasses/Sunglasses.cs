﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                for (int row = 1; row <= n; row++)
                {
                    if (row == 1 || row == n)
                    {
                        for (int col = 0; col < 2 * n; col++)
                            Console.Write("*");
                        for (int col = 0; col < n; col++)
                            Console.Write(" ");
                        for (int col = 0; col < 2 * n; col++)
                            Console.Write("*");
                    }
                    else if (row == n / 2)
                    {
                        Console.Write("*");
                        for (int col = 0; col < n + n - 2; col++)
                            Console.Write("/");
                        Console.Write("*");
                        for (int col = 0; col < n; col++)
                            Console.Write("|");
                        Console.Write("*");
                        for (int col = 0; col < n + n - 2; col++)
                            Console.Write("/");
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("*");
                        for (int col = 0; col < n + n - 2; col++)
                            Console.Write("/");
                        Console.Write("*");
                        for (int col = 0; col < n; col++)
                            Console.Write(" ");
                        Console.Write("*");
                        for (int col = 0; col < n + n - 2; col++)
                            Console.Write("/");
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int row = 1; row <= n; row++)
                {
                    if (row == 1 || row == n)
                    {
                        for (int col = 0; col < 2 * n; col++)
                            Console.Write("*");
                        for (int col = 0; col < n; col++)
                            Console.Write(" ");
                        for (int col = 0; col < 2 * n; col++)
                            Console.Write("*");
                    }
                    else if (row == (n + 1) / 2)
                    {
                        Console.Write("*");
                        for (int col = 0; col < n + n - 2; col++)
                            Console.Write("/");
                        Console.Write("*");
                        for (int col = 0; col < n; col++)
                            Console.Write("|");
                        Console.Write("*");
                        for (int col = 0; col < n + n - 2; col++)
                            Console.Write("/");
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("*");
                        for (int col = 0; col < n + n - 2; col++)
                            Console.Write("/");
                        Console.Write("*");
                        for (int col = 0; col < n; col++)
                            Console.Write(" ");
                        Console.Write("*");
                        for (int col = 0; col < n + n - 2; col++)
                            Console.Write("/");
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

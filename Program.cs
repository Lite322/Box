using System;
namespace Box
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Я программа для выведения на экран квадрата из нулей и единиц, при чём нули находятся только на диагоналях квадрата.")
int a = Convert.Int32(Console.ReadLine());
            int b = Convert.Int32(Console.ReadLine());
            int c = 0;
            int d = c;//задаются основные параметры. Т.к. у квадрата все стороны равны, то можно задать только одну его сторону.
            int[,] square = new int[a, b];
            for (c = 0; c < a; c++)
            {
                for (d = 0; d < b; d++)
                {
                    if (c == d)
                    {
                        square[c, d] = 0;
                    }
                    else
                    {
                        square[c, d] = 1;
                    }
                }
            }
            c--;
            d--;
            if (c == a * 1 && d == b * 1)
            {
                d = 0;
                while (c >= 0 && d < b)
                {
                    square[c, d] = 0;
                    c--;
                    d++;
                }
            }
            for (c = 0; c < a; c++)
            {
                for (b = 0; b < b; b++)
                {
                    Console.Writeline(square[c, j] + " ");
                }
                Console.Writeline("\n")
            }
        }
    }
}

using System;
    namespace Box
{
    class MainClass
    {
        public static void Main(string[]args)
        {
        string s1 = "Я пограмма для выведения на экран квадратов из нулей и единиц, причем нули находятся только на диагоналях квадрата."
        string s2 = "Пожалуйста, введите сторону квадарата"
        string[] values = new string[] { s1, s2 };
        string s3 = string.Join(" ", values);
        Console.WriteLine(s3);
            int size = Console.Read();
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                    if (x == y || x == size - y)
                    { Console.Write("0"); }
                    else
                    { Console.Write("1"); }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

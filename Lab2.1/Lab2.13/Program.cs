﻿namespace Lab2._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập vào ba cạnh của tam giác
            Console.Write("Nhập cạnh a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập cạnh b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhập cạnh c: ");
            int c = int.Parse(Console.ReadLine());

            // Kiểm tra nếu a, b, c có phải là ba cạnh của một tam giác
            if (a + b > c && a + c > b && b + c > a)
            {
                // Xác định loại tam giác
                if (a == b && b == c)
                {
                    Console.WriteLine("Đây là tam giác đều.");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Đây là tam giác cân.");
                }
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    Console.WriteLine("Đây là tam giác vuông.");
                }
                else
                {
                    Console.WriteLine("Đây là tam giác thường.");
                }
            }
            else
            {
                Console.WriteLine("a, b, c không phải là ba cạnh của một tam giác.");
            }
        }
    }
}

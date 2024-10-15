namespace Lab2._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hình a:");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nHình b:");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nHình c:");

            int height = 5; // Chiều cao của tam giác

            for (int i = 1; i <= height; i++)
            {
                // In ra khoảng trắng trước dấu *
                Console.Write(new string(' ', height - i));

                // In ra dấu * với số lượng lẻ (1, 3, 5, ...)
                Console.WriteLine(new string('*', 2 * i - 1));
            }
        }
    
    }
}

namespace Lab2._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 10;
            for (int i = 1; i <= rows; i++) 
            {
                Console.Write(new string(' ',(rows-i)));
                int num = i;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num % 10);
                    num++;
                }
                num -= 2;
                for (int j = 1;  j < i; j++)
                {
                    Console.Write(num % 10);
                    num--;
                }
                Console.WriteLine();
            }
        }
    }
}

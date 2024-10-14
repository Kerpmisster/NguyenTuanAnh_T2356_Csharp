namespace Lab2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum  = 0;
            for (int i = 1; i <= 100; i++) 
            {
                if (i % 2 == 0 && i % 3 != 0)
                {
                    sum+=1;  
                }
            }

            Console.WriteLine("Tong cac chu so tu 1-100 khong chia het cho 3 la:{0}",sum);
        }
    }
}

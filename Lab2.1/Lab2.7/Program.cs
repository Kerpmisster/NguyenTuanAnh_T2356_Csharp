namespace Lab2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Thang", "Long", "Khoa", "Dao" };
            Console.WriteLine("Danh sach sinh vien:\n");
            foreach (var n  in name)
            {
                Console.WriteLine(n);
            }
        }
    }
}

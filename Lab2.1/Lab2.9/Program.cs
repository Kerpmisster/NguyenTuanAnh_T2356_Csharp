namespace Lab2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập năm (x): ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Nhập tháng (y): ");
            int y = int.Parse(Console.ReadLine());

            // Kiểm tra số ngày trong tháng
            int daysInMonth = DateTime.DaysInMonth(x, y);

            // In ra kết quả
            Console.WriteLine($"Số ngày trong tháng {x} của năm {y} là: {daysInMonth}");
        }
    }
}

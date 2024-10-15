namespace Lab2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập số giây từ người dùng
            Console.Write("Nhập số giây: ");
            int totalSeconds = int.Parse(Console.ReadLine());

            // Tính số giờ, phút và giây
            int hours = totalSeconds / 3600; // 1 giờ = 3600 giây
            int minutes = (totalSeconds % 3600) / 60; // 1 phút = 60 giây
            int seconds = totalSeconds % 60; // Số giây còn lại

            // In ra kết quả định dạng hh:mm:ss
            Console.WriteLine($"{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}

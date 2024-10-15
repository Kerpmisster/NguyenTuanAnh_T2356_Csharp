namespace Lab2._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so tien gui:");
            double soTienGui = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap lai suat ngan hang ban(%):");
            double laiSuatNam = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thang gui:");
            int soThangGui = int.Parse(Console.ReadLine());

            double laiSuatThang = laiSuatNam / 12;
            double soDu = soTienGui;
            Console.WriteLine("Thang\t So du\t Lai");
            for (int thang = 1; thang <= soThangGui; thang++)
            {
                double lai = soDu * laiSuatThang;
                soDu += lai;
                Console.WriteLine($"{thang}\t{soDu:N2}\t{lai:N2}");
            }
            double tongLai = soDu - soTienGui;
            Console.WriteLine($"Tong lai sau{soThangGui} thang:{tongLai:N2}")
        }
    }
}

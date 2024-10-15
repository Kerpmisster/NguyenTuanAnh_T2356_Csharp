namespace Lab2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Id, Name, Address;
            DateTime Birthday;
            double Salary, Bonus, TotalSalary;

            Id = "006";
            Name = "Nguyen Tuan Anh";
            Address = "Ha Noi";
            Birthday = new DateTime(2003,09,29);
            Salary = 29;
            Bonus = 5;
            TotalSalary = Salary + Bonus;

            Console.WriteLine("\n Thong tin sinh vien");
            Console.WriteLine("Ma SV:" + Id);
            Console.WriteLine("Ho va ten:" +  Name);
            Console.WriteLine("Dia chi:" + Address);
            Console.WriteLine("Ngay sinh:{0:dd/MM/yyyy}", Birthday);
            Console.WriteLine("Luong:"+ Salary);
            Console.WriteLine("Thuong:" +  Bonus);
            Console.WriteLine("Tong luong:" +  TotalSalary);
        }
    }
}

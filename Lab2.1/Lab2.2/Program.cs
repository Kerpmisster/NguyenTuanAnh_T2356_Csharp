namespace Lab2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int numnber;
            double money = 0;

            Console.WriteLine("Nhap ten thue bao:");
            name = Console.ReadLine();
            Console.WriteLine("Nhap so dien su dung:");
            numnber = Convert.ToInt32(Console.ReadLine());
            if (numnber <= 30)
                money = 30;
            else if (numnber > 30 && numnber <= 50)
                money = 30 + (numnber - 30) * 1.2;
            else if (numnber > 50)
                money = 30 + 20 * 1.2 + (numnber - 50) * 1.5;
            Console.WriteLine("\n Thong tin tien dien:");
            Console.WriteLine("Ho va ten:{0}", name);
            Console.WriteLine("So dien su dung:{0}", numnber);
            Console.WriteLine("So tien:{0}", money);
           
        }
    }
}

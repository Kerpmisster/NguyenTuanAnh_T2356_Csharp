namespace Lab5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student(3, 2);
            std[0] = "Nguyen";
            std[0, 0] = 9;
            std[0, 1] = 9.5;
            std[1] = "Tuan";
            std[1, 0] = 8;
            std[1, 1] = 9.8;
            std[2] = "Anh";
            std[2, 0] = 10;
            std[2, 1] = 7.5;
            Console.WriteLine("Thong tin sinh vien");
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("Ho va ten:"+std[i]);
                Console.WriteLine("Diem:");
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine(std[i,j] + ",");
                }
                Console.WriteLine();
            }
        }
    }
}

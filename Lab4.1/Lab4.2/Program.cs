namespace Lab4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student of College:");
            StudentCollege std1 = new StudentCollege("Tuan Anh",2003,9.5,8,7);
            std1.Display();
            Console.WriteLine("Average of score: {0}", std1.Average());
            Console.WriteLine("Student of University:");
            StudentUniversity std2 = new StudentUniversity("Dan", 2003, 10, 9, 9, 5);
            std2.Display();
            Console.WriteLine("Average of score: {0}", std2.Average());
        }
    }
}

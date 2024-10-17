namespace Lab4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.InputData();
            Console.WriteLine("Dien tich hinh chu nhat la: {0:N}", rec.Area());
            Console.WriteLine("Chu vi hinh chu nhat la: {0:N}", rec.Circumference());

            Circle circle = new Circle();
            circle.InputData();
            Console.WriteLine("Dien tich trong la: {0:N}", circle.Area());
            Console.WriteLine("Chu vi hinh tron la: {0:N}", circle.Circumference());
        }
    }
}

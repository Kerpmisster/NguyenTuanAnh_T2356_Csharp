using Business.DealerShip;
namespace Lab7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Business.House house = new Business.House();
            house.HouseNo = "H2K03TT";
            house.Price = 100000;

            Console.WriteLine("House Detail");
            Console.WriteLine("\t House No: " + house.HouseNo);
            Console.WriteLine("\t Price: " + house.Price);

            Car c = new Car();
            c.CarNo = "A0239";
            c.Price = 100.00M;

            Console.WriteLine("Car Detail");
            Console.WriteLine("\t Car No: " + c.CarNo);
            Console.WriteLine("\t Price: " + c.Price);
        }
    }
}

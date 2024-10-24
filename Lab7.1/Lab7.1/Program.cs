using Store;
namespace Lab7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supply.Manufacture dealer = new Supply.Manufacture();
            dealer.Name = "Test";
            dealer.Email = "Test@gmail.com";
            dealer.Phone = "1234567890";

            Console.WriteLine("Dealer information");
            Console.WriteLine("\t Name: " +  dealer.Name);
            Console.WriteLine("\t Email: "+ dealer.Email);
            Console.WriteLine("\t Phone: " + dealer.Phone);

            StoreItem item = new StoreItem();
            item.ItemNo = 1;
            item.ItemName = "Test";
            item.Price = 80.00M;

            Console.WriteLine("Store Inventory");
            Console.Write("\t Item #: ");
            Console.WriteLine(item.ItemNo);
            Console.Write("\t Item Name: ");
            Console.WriteLine(item.ItemName);
            Console.Write("\t Item Price: ");
            Console.WriteLine(item.Price);
        }
    }
}

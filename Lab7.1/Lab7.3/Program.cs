namespace Lab7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[5];
            try 
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("a[{0}]=", i + 1);
                    data[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch (FormatException e) 
            {
                Console.WriteLine("Khong duoc nhap ki tu cho mang so");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Khong duoc nhap gia tri nam ngoai mien 0-225");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Loi vuot qua pham vi cua mang");
            }

            Console.WriteLine("Noi dung cua mang");
            for (int i = 0;i < 5;i++)
            {
                Console.WriteLine("{0}", data[i]);
            }    
        }
    }
}

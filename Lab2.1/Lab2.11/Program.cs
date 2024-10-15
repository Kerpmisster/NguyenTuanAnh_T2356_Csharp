namespace Lab2._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Các số từ 100 đến 999 có tổng 3 chữ số là chẵn:");

            // Lặp qua các số từ 100 đến 999
            for (int i = 100; i <= 999; i++)
            {
                // Tách các chữ số
                int hundreds = i / 100;       // Chữ số hàng trăm
                int tens = (i / 10) % 10;     // Chữ số hàng chục
                int ones = i % 10;            // Chữ số hàng đơn vị

                // Tính tổng 3 chữ số
                int sum = hundreds + tens + ones;

                // Kiểm tra nếu tổng là số chẵn
                if (sum % 2 == 0)
                {
                    // In ra số đó
                    Console.WriteLine(i);
                }
            }
        }
    }
}

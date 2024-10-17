namespace Lab4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1000);
            // in ra số tiền trong tài khoản
            Console.WriteLine("Số tiền trong tài khoản: " + account.GetBalance());
            // nạp thêm 500 vào tài khoản
            account.Deposit(500);
            // in số tiền trong tài khoản sau khi nạp
            Console.WriteLine("Số tiền trong tài khoản sau khi nạp:" + account.GetBalance());
            // Rút 300 từ tài khoản
            account.WithDraw(300);
            // In ra số tiền trong tài khoản sau khi rút
            Console.WriteLine("Số tiền trong tài khoản sau khi rút:" + account.GetBalance());
            Console.ReadKey();
        }
    }
}

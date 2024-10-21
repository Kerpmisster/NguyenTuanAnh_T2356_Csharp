namespace Lab5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] m = { 5,8,3,0,2,1,7,8 };
            Console.WriteLine("Cac phan tu cua mang");
            for (int i = 0; i < m.Length; i++) 
            {
                Console.WriteLine("{0}", m[i]);    
            }
            int max = m[0];
            for (int i = 1; i < m.Length; i++)
            {
                if (m[i] > max)
                    m[i] = max;
            }
            Console.WriteLine("\n Phan tu lon nhat:" +  max);
            bool kt = true;
            for (int i = 0;i < m.Length/2; i++)
            {
                if (m[i] != m[m.Length-1-i])
                    kt = false;
                break;
            }
            if (kt)
                Console.WriteLine("Mang doi xung");
            else
                Console.WriteLine("Mang khong doi xung");
        }
    }
}

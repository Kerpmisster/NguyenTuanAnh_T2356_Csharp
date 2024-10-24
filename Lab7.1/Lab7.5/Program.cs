using DongVat.AnCo;
using DongVat.AnThit;
namespace DongVat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bo bo = new Bo(1, "Bo", 500);
            Trau trau = new Trau(2, "Trau", 1000);
            De de = new De(3, "De", 500);

            CaSau caSau = new CaSau(4, "Ca Sau", 1000);
            Ho ho = new Ho(5, "Ho", 2000);
            SuTu suTu = new SuTu(6, "Su Tu", 220);

            Console.WriteLine(bo.GetInfo());
            Console.WriteLine(trau.GetInfo());
            Console.WriteLine(de.GetInfo());
            Console.WriteLine(caSau.GetInfo());
            Console.WriteLine(ho.GetInfo());
            Console.WriteLine(suTu.GetInfo());
        }
    }
}

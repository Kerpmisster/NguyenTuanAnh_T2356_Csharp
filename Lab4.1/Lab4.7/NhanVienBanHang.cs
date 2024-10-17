using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._7
{
    internal class NhanVienBanHang : NhanVien
    {
        public override void HienThi(string Ten, string DiaChi)
        {
            Console.WriteLine("Ten: {0}, Dia chi:{1} ", Ten, DiaChi);
        }

        public override double TinhLuong(double Day, double high)
        {
            return Day * high;
        }
    }
}

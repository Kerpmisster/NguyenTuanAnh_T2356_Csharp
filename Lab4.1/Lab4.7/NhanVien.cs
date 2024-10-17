using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._7
{
    internal abstract class NhanVien
    {
        public string Ten;
        public string DiaChi;
        public NhanVien() { }
        public NhanVien(string Ten, string DiaChi)
        {
            this.Ten = Ten;
            this.DiaChi = DiaChi;
        }
        public abstract double TinhLuong(double Day, double high);
        public abstract void HienThi(string Ten, string DiaChi);
    }
}

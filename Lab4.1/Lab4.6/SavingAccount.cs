using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._6
{
    internal class SavingAccount : Account
    {
        private decimal rate;// tỉ lệ lãi suất
        // Constructor với 3 tham số đầu vào để khoeir tạo giá trị ban đầu
        public SavingAccount(decimal initialize, decimal rate) : base(initialize)
        {
            if (rate < 0)
            {
                Console.WriteLine("Ti le lai suat khong hop le");
            }
            this.rate = rate;
        }
        // Phương thức để lấy tiền lãi
        public decimal GetInterest()
        {
            return rate * rate;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._6
{
    internal abstract class Account
    {
        public decimal Balance;
        // Constructor với tham số đầu vào
        public Account(decimal initialize)
        {
            if (initialize < 0)
            {
                throw new ArgumentException("Số tiền đầu vào không hợp lệ");
            }
            Balance = initialize;
        }
        // tạo phương thức cho lớp Account

        // Phương thức trả về số tiền trong tài khoản

        // Phương thức gửi tiền cho ghi đè
        public virtual void Deposit(decimal money)
        {
            if (money > 0)
            {
                Balance += money;
            }
            else
            {
                throw new ArgumentException(" Số tiền nạp vào không hợp lệ");
            }
        }
        // Phương thức rút tiền từ tài khoản
        public virtual void WithDraw(decimal money)
        {
            if (money <= 0)
            {
                throw new ArgumentException("Số tiền rút không hợp lệ");
            }
            if (money > Balance)
            {
                throw new ArgumentException("Không đủ số dư để rút tiền");
            }
            else
            {
                Balance -= money;
            }
        }
        public decimal GetBalance()
        {
            return Balance;
        }
    }
}

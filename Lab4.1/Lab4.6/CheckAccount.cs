using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._6
{
    internal class CheckAccount : Account
    {
        private decimal Fee;
        public CheckAccount(decimal initialize,decimal Fee) 
            : base(initialize)
        {
            if(Fee < 0) 
            {
                Console.WriteLine("Phi giao dich khong hop le");
            }
            this.Fee = Fee;
        }
        public override void Deposit(decimal money)
        {
            base.Deposit(money);

        }
        public override void WithDraw(decimal money)
        {
            base.WithDraw(money);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_ptojectHDH
{
    internal class process
    {
        Bank bank;
        bool flag;
        int amount;
        public process(Bank bank,bool flag,int amount)
        {
            this.bank = bank;
            this.flag = flag;
            this.amount = amount;
        }
        public void run()
        {
            if (flag)
            {
                bank.withdraw(amount);
            }
            else
            {
                bank.Deposit(amount);
            }
        }
    }
}

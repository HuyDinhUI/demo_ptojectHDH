using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_ptojectHDH
{
    internal class Bank
    {
        private object khoa = new object();
        private int Balance;
        public Bank(int Balance)
        {
            this.Balance = Balance;
        }

        public Bank()
        {
            Balance = 0;
        }

        public void Deposit(int money_deposit)
        {
            lock (khoa)
            {
                Console.WriteLine("Deposit amount:{0}", money_deposit);
                Balance = Balance + money_deposit;
                Console.WriteLine("Total balance after deposit:{0}", Balance);

            }
        }

        public void withdraw(int money_withdraw)
        {
            lock (khoa)
            {

                if (Balance >= money_withdraw)
                {
                    Balance -= money_withdraw;
                    Console.WriteLine("Withdraw amount:{0}",money_withdraw);
                    Console.WriteLine("Total balance after draw:{0}", Balance);
                }
                else
                {
                    Console.WriteLine("No enough.");
                }
            }
        }
        public void xuat_balance()
        {
            Console.WriteLine("Balance:{0}",Balance);
        }
        //public bool condition_CS()
        //{
        //    if (Balance>money_withdraw)
        //        return true;
        //    else return false;
        //}
        //public void CS()
        //{
        //    if (condition_CS()==true)
        //    {
        //        withdraw();
        //    }
        //    else Deposit();
        //}

    }
}


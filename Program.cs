using demo_ptojectHDH;
using System;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;



class ChuongTrinh
{
    static void Main()
    {
        Random rnd = new Random();
        int balance=rnd.Next(10000,50000);
        
        Bank bank= new Bank();
        for (int i = 0; i < 50; i++)
        {
            int amount1 = rnd.Next(50, 10000);
            int amount2 = rnd.Next(50, 10000);
            Thread t1 = new Thread(() =>
            {
                bank.withdraw(amount1);
            });
            Thread t2 = new Thread(() =>
            {
                bank.Deposit(amount2);
            });
            t1.Start();
            t2.Start();
            Thread.Sleep(1000);
        }
      
        Console.ReadKey();
    }
}
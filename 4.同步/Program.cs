using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 同步
{
    class Program
    {
        static int tickets = 100;
        static object gloalObj = new object();
        static void Main(string[] args)
        {
           
            Thread thread1 = new Thread(SaleTicketThread1);
            Thread thread2 = new Thread(SaleTicketThread2);
            thread1.Start();
            thread2.Start();
            Thread.Sleep(4000);
            Console.ReadKey();
        }

        private static void SaleTicketThread1()
        {
            while (true)
            {
                try
                {
                    Monitor.Enter(gloalObj);
                    if (tickets > 0)
                        Console.WriteLine("线程1出票：" + tickets--);
                    else
                        break;
                }
                finally
                {
                    Monitor.Exit(gloalObj);
                }

            }
        }
        private static void SaleTicketThread2()
        {
            try
            {
                while (true)
                {
                    Monitor.Enter(gloalObj);
                    if (tickets > 0)
                        Console.WriteLine("线程2出票：" + tickets--);
                    else
                        break;
                }
            }
            finally
            {
                Monitor.Exit(gloalObj);
            }
        }
    }
}

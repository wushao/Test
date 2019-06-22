using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 前后台线程
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread backThread = new Thread(Worker);
            backThread.IsBackground = true;
            backThread.Start();
            Console.WriteLine("从主线程中退出");
        }

        public static void Worker()
        {
            Thread.Sleep(5000);
            Console.WriteLine("从后台线程退出");
        }
    }
}

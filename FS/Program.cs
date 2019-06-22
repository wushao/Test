using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly aly = Assembly.Load("FSDLL");

            //var al = aly.GetModules();

            //Type ty = aly.GetType("FSDLL.Test1");

            //var test = Activator.CreateInstance(ty);
            //var str =(test as dynamic).Test();

            //Test1_2 tt = new TT();

        }


    }

    interface Test1
    {

    }

    interface Test1_1 : Test1
    {

    }
    interface Test1_2 : Test1
    {

    }


    public class TT : Test1_1
    {
       public void Ts()
        {
            Console.WriteLine("TT");
        }
    }
}

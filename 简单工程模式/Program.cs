using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工程模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数字1");
            var num1 = Console.ReadLine();
            Console.WriteLine("数字2");
            var num2 = Console.ReadLine();
            Console.WriteLine("符号");
            var fuhao = Console.ReadLine();

            Test0 t = SimpleFactory.Get(fuhao);
            t.Num1 = num1;
            t.Num2 = num2;
            Console.WriteLine(t.GetResult());
            Console.ReadKey();
        }

    }


    static class SimpleFactory
    {
        public static Test0 Get(string op)
        {
            Test0 t = null;
            switch (op)
            {
                case "+": t = new Test1(); break;
                case "-": t = new Test2(); break;
            }
            return t;
        }
    }

    abstract class Test0
    {
        public string Num1 { get; set; }
        public string Num2 { get; set; }

        public abstract int GetResult();
      
    }

    class Test1: Test0
    {

        public override int GetResult()
        {
            return Convert.ToInt32(base.Num1) + Convert.ToInt32(base.Num2);
        }
    }

    class Test2: Test0
    {
        public override int GetResult()
        {
            return Convert.ToInt32(base.Num1) - Convert.ToInt32(base.Num2);
        }
    }
}

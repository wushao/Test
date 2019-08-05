using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace JC
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = TestManager.Msg();
            Test1 test1 = (Test1)test;
            test.Msg();
            test1.Msg();
            Console.ReadKey();
        }
    }

    public class TestManager
    {
        public static Test Msg()
        {
            ObjectHandle handler = Activator.CreateInstance(null, "JC.Test1");
            Object obj = handler.Unwrap();
            var test = (Test)obj;
            return test;
;        }
    }

    public class Test
    {
        public virtual void Msg()
        {
            Console.WriteLine("Test");
        }
    }

    public class Test1 : Test
    {
        public override void Msg()
        {
            Console.WriteLine("Test1");
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test st = Test.TS();
            //var obj1 = st.OBJ;
            //Test st1 = Test.TS();
            //var obj2 = st.OBJ;
            //if (ReferenceEquals(obj1, obj2))
            //{
            //    Console.WriteLine(ReferenceEquals(obj1, obj2));
            //}
            var t1 = Test.st;
            var t2 = Test.st;
            if (ReferenceEquals(t1,t2 ))
            {
                Console.WriteLine(ReferenceEquals(t1, t2));
            }
            Console.ReadKey();
        }

        public class Test
        {
            private static object obj = new object();
            public static Test st = new Test();
            private Test()
            {
               
            }
         

            //public static Test TS()
            //{
            //    if (st == null)
            //    {
            //        lock (obj)
            //        {
            //            if (st == null)
            //            {
            //                st = new Test();
            //            }
            //        }
            //    }
            //    return st;
            //}

            //public object OBJ
            //{
            //    get { return obj; }
            //}
        }
    }
}

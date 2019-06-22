using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegete
{
    public delegate void TestDelegate(string str);
    class Program
    {
        static int i = 1;
       
        static void Main(string[] args)
        {
            //TestDelegate t = new TestDelegate(Test1);

            ////Test(t, "Test1");

            //Action<string> a = new Action<string>(Test1);
            ////Test_(a, "Test2");

            //Test_((str)=> { Console.WriteLine(str); }, "Test3");


            //Action<int> ac = (j) => { Console.WriteLine(++j);  };
            //ac += (j) => { Console.WriteLine(++j); };
            //ac.Invoke(i);


            new Cat().Zhixing();

            Console.ReadKey();
           
           
           
        }  

        public static void Test(TestDelegate t,string str)
        {
            t.Invoke(str);
            Console.WriteLine("Test");
        }

        public static void Test_(Action<string> t, string str)
        {
            t.Invoke(str);
            Console.WriteLine("Test_");
        }

        public static void Test1(string str1)
        {
            Console.WriteLine(str1);
        }

        public static void Test2(string str2)
        {
            Console.WriteLine(str2);
        }
    }

    public class Cat
    {
        
        public static Action acn = () => { Console.WriteLine("猫叫"); };
        public void Zhixing()
        {
            acn.Invoke();
        }
    }
    public class Dog
    {
      
        public Dog()
        {
           Cat.acn += Jiao;
        }
       
        public void Jiao()
        {
            Console.WriteLine("狗叫");
        }
    }
}

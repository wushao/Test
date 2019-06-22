using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FX
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Stopwatch sh = new Stopwatch();
            sh.Start();
            Test<int>.SetData(1);
            int i = Test<int>.GetData();

            Test<string>.SetData("a");
            string str = Test<string>.GetData();

            Test<int>.SetData(11);
            int j = Test<int>.GetData();

            sh.Stop();
            var h= sh.ElapsedMilliseconds;

            List<int> list = new List<int>() { 12, 3, 4, 5, 6, 7, 8, 9 };

            var lt = list.Where(c => c == 1);
            list.Sum();
            Dictionary<string, string> dic = new Dictionary<string, string>();
            var dc = dic.GroupBy(d => d.Key == "a");
                
        }

        
    }

    public class Test<T>
    {
        public static Dictionary<string, T> dic = null;

        static Test()
        {
            dic = new Dictionary<string, T>();
        }
        public static void SetData(T dt)
        {
            //if (!dic.Keys.Contains(typeof(T).Name)) { } else { }
            dic[typeof(T).Name] = dt;
        }
        public static T GetData()
        {
            return dic[typeof(T).Name];
        }
    }


    public class Test1<T>
    {
        public static List<T> GetList(List<T> list,Func<T,bool> func)
        {
            List<T> lt = new List<T>();

            for(var i = 0; i < list.Count; i++)
            {
                if (func.Invoke(list[i]))
                {
                    lt.Add(list[i]);
                }
            }

            return lt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //double number;
            //string input = "1111";
            //var i = double.TryParse(input, out number);

            //Trace.Assert

            string str = string.Empty;
            //str?.Length

            student st = new student();
            //if(st?.name)
        }

    }

    class student
    {
        public string name { get; set; }
    }
}

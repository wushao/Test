using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "E:\\test.txt";
            using (FileStream fileStream = File.Open(filePath, FileMode.OpenOrCreate))
            {
                string msg = "Fuck";
                byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
                Console.WriteLine("开始写入{0}到文件中",msg);
                fileStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
                fileStream.Seek(0,SeekOrigin.Begin);
                Console.WriteLine("开始读取写入的信息");
                byte[] bytesFromFile = new byte[msgAsByteArray.Length];
                fileStream.Read(bytesFromFile,0,msgAsByteArray.Length);
                Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
                Console.Read();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriteRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "E:\\test.txt";
            using (FileStream fileStream = File.Open(filePath, FileMode.OpenOrCreate))
            {
                var file1 = fileStream;
                string msg = "Fuck";
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    Console.WriteLine("开始写入 {0}到文件中", msg);
                    writer.Write(msg);
                    var file2 = fileStream;

                    var file3 = fileStream;
                    StreamReader reader = new StreamReader(fileStream);
                    Console.WriteLine("写入文件的内容是:{0}", reader.ReadToEnd());
                }
                Console.ReadLine();
            }
        }
    }
}

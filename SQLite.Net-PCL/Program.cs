using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLite.Net_PCL
{
    class Program
    {
        static void Main(string[] args)
        {
            //数据库文件路径就在运行目录下
           var  dbPath = $"{Environment.CurrentDirectory}\\mybooks.db";
            List<Book> books = new List<Book>()
            {
                new Book() { Name = "射雕英雄传", PublishDate = new DateTime(1960, 1, 1), Author = "金庸", Price = 10.5f },
                new Book() { Name = "神雕侠侣", PublishDate = new DateTime(1960, 2, 2), Author = "金庸", Price = 12.5f },
                new Book() { Name = "倚天屠龙记", PublishDate = new DateTime(1960, 3, 3), Author = "金庸", Price = 16.5f },
                new Book() { Name = "小李飞刀", PublishDate = new DateTime(1965, 5, 5), Author = "古龙", Price = 13.5f },
                new Book() { Name = "绝代双骄", PublishDate = new DateTime(1965, 6, 6), Author = "古龙", Price = 15.5f },
            };

            using (var db = new MyBookDB(dbPath))
            {
                int count = db.InsertAll(books);
                var text = $"{DateTime.Now}, 插入{count}条记录";
                Console.WriteLine(text);
                Console.ReadKey();
            }

        }
    }



    public class Book
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public string Name { get; set; }//书名

        public DateTime PublishDate { get; set; }//出版日期

        public string Author { get; set; }//作者

        public float Price { get; set; }//价格
    }
    public class MyBookDB : SQLiteConnection
    {
        //定义属性，便于外部访问数据表
        public TableQuery<Book> Books { get { return this.Table<Book>(); } }

        public MyBookDB(string dbPath) : base(dbPath)
        {
            //创建数据表
            CreateTable<Book>();
        }
    }

}

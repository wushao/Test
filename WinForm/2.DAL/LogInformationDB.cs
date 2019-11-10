using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm.Model;

namespace WinForm.DAL
{
    public class LogInformationDB : SQLiteConnection
    {
        //定义属性，便于外部访问数据表
        public TableQuery<LogModel> LogInformations
        {
            get { return this.Table<LogModel>(); }
        }

        public LogInformationDB(string dbPath) : base(dbPath)
        {
            //创建数据表
            CreateTable<LogModel>();
        }
    }
}

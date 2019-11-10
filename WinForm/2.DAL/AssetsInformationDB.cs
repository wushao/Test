using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinForm.Model;

namespace WinForm.DAL
{
    public class AssetsInformationDB : SQLiteConnection
    {
        //定义属性，便于外部访问数据表
        public TableQuery<AssetsInformation> AssetsInformations
        {
            get
            {
                return this.Table<AssetsInformation>();
            }
        }

        public AssetsInformationDB(string dbPath) : base(dbPath)
        {
            //创建数据表
            CreateTable<AssetsInformation>();
        }
    }
}

using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.DAL;
using WinForm.Model;

namespace WinForm.UI
{
    public partial class FormLog : FrmWithTitle
    {
        string dbPath = $"{Environment.CurrentDirectory}\\AssetsInformation.db";
        public string Code { get; set; }
        public FormLog()
        {
            InitializeComponent();
        }

        private void GetList()
        {
            using (var db = new LogInformationDB(dbPath))
            {
                List<LogModel> source = new List<LogModel>();
                if (!string.IsNullOrWhiteSpace(Code))
                {
                    source = db.Query<LogModel>($"select * from LogModel where AssetCode='{Code}'");
                }

               DataGrid.DataSource = source;
               DataGrid.ReloadSource();
            }
        }
    }
}

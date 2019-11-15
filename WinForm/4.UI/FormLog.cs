using MetroFramework.Forms;
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
using WinForm.UI.DataDescriptors;
using WinForm.UI.Extenders;

namespace WinForm.UI
{
    public partial class FormLog : MetroForm
    {
        string dbPath = $"{Environment.CurrentDirectory}\\AssetsInformation.db";
        public string Code { get; set; }

        public FormLog()
        {
            InitializeComponent();
            Initialize();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void Initialize()
        {
           
        }

        private void GetList()
        {
            using (var db = new LogInformationDB(dbPath))
            {
                List<LogModel> source = new List<LogModel>();
                if (!string.IsNullOrWhiteSpace(Code))
                {
                    source = db.Query<LogModel>($"select AssetName from LogModel where AssetCode='{Code}'");
                    if(source!=null && source.Any())
                    {
                        this.DataGrid.GenerateColumns(source,
                                      new ColumnDataDescriptor("资产名称", new DataColumn() { DataType=typeof(string), ColumnName= "AssetName",  }));
                        this.DataGrid.PrepareStyleForEditingData();
                        this.DataGrid.AddDataRowStateDrawingInRowHeaders();
                    }
                }
            }
        }
    }
}

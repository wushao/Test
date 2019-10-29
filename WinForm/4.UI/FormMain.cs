using HZH_Controls.Controls;
using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinForm.Model;

namespace WinForm.UI
{
    public partial class FormMain :  FrmWithTitle
    {
        public FormMain()
        {
            InitializeComponent();
            DataGrid.SizeChanged += DataGrid_SizeChanged;
            DataGrid.IsCloseAutoHeight = false;
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            List<DataGridViewColumnEntity> lstCulumns = new List<DataGridViewColumnEntity>();
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "ID", HeadText = "编号", Width = 70, WidthType = SizeType.Absolute });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Name", HeadText = "姓名", Width = 50, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Age", HeadText = "年龄", Width = 50, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Birthday", HeadText = "生日", Width = 50, WidthType = SizeType.Percent, Format = (a) => { return ((DateTime)a).ToString("yyyy-MM-dd"); } });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Sex", HeadText = "性别", Width = 50, WidthType = SizeType.Percent, Format = (a) => { return ((int)a) == 0 ? "女" : "男"; } });
            this.DataGrid.Columns = lstCulumns;
            this.DataGrid.IsShowCheckBox = true;
            List<object> lstSource = new List<object>();
            for (int i = 0; i < 50; i++)
            {
                TestGridModel model = new TestGridModel()
                {
                    ID = i.ToString(),
                    Age = 3 * i,
                    Name = "姓名——" + i,
                    Birthday = DateTime.Now.AddYears(-10),
                    Sex = i % 2
                };
                lstSource.Add(model);
            }

            var page = new UCPagerControl2();
            page.DataSource = lstSource;
            this.DataGrid.Page = page;
            this.DataGrid.First();
        }

        private void DataGrid_SizeChanged(object sender, EventArgs e)
        {
            if (this.DataGrid.Page != null)
            {
                this.DataGrid.Page.PageSize = this.DataGrid.ShowCount;
                this.DataGrid.DataSource = this.DataGrid.Page.GetCurrentSource();
            }
        }
    }

    
}

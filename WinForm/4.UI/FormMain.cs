using HZH_Controls.Controls;
using HZH_Controls.Forms;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using WinForm.DAL;
using WinForm.Model;

namespace WinForm.UI
{
    public partial class FormMain :  FrmWithTitle
    {
        string dbPath = $"{Environment.CurrentDirectory}\\AssetsInformation.db";
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            List<DataGridViewColumnEntity> lstCulumns = new List<DataGridViewColumnEntity>();
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "ID", HeadText = "序号", Width = 70, WidthType = SizeType.Absolute });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "AssetName", HeadText = "资产名称", Width = 50, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "AssetCode", HeadText = "资产编码", Width = 50, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "ManagementDepartment", HeadText = "管理部门", Width = 50, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "UseDepartment", HeadText = "使用部门", Width = 50, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "UseState", HeadText = "使用状态", Width = 50, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "UseDate", HeadText = "使用年限", Width = 50, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "UsePlace", HeadText = "使用地点", Width = 50, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "InstallationDate", HeadText = "安装日期", Width = 100, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "QdPath", HeadText = "二维码", Width = 100, WidthType = SizeType.Percent });
            //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "AssetModel", HeadText = "资产型号", Width = 50, WidthType = SizeType.Percent, Format = (a) => { return ((DateTime)a).ToString("yyyy-MM-dd"); } });
            //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Sex", HeadText = "性别", Width = 50, WidthType = SizeType.Percent, Format = (a) => { return ((int)a) == 0 ? "女" : "男"; } });
            this.DataGrid.Columns = lstCulumns;
            this.DataGrid.IsShowCheckBox = true;
           
            using (var db = new AssetsInformationDB(dbPath))
            {
                var list = db.Query<AssetsInformation>("select * from assetsinformation");
                DataGrid.DataSource = list;
            }

    }



        private void BtnAdd_BtnClick(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit();
            formEdit.ShowDialog();
        }

        private void BtnImport_BtnClick(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel表格|*.xlsx";
            fileDialog.CheckFileExists = true;
            if (fileDialog.ShowDialog() == DialogResult.OK &&   !string.IsNullOrWhiteSpace(fileDialog.FileName))
            {
                //获取excel文件
                var file = new System.IO.FileInfo(fileDialog.FileName);
                System.Data.DataTable dt = null;
                using (var package = new ExcelPackage(file))
                {
                    //获取workbook
                    ExcelWorkbook workbook = package.Workbook;
                    if (workbook != null)
                    {
                        if (workbook.Worksheets.Count > 0)
                        {    
                            //获取workbook的第一个worksheet
                            ExcelWorksheet worksheet = workbook.Worksheets[1];
                            //将worksheet转成datatable
                            dt = Common.ExcelHelper.WorksheetToTable(worksheet);
                            if (dt != null && dt.Rows.Count > 0)
                            {
                                List<AssetsInformation> list = new List<AssetsInformation>();
                                foreach (DataRow row in dt.Rows)
                                {
                                    AssetsInformation entity = new AssetsInformation();
                                    entity.AssetName = row["资产名称"]?.ToString();
                                    entity.AssetCode = row["资产编码"]?.ToString();
                                    entity.AssetModel = row["资产型号"]?.ToString();
                                    entity.ManagementDepartment = row["管理部门"]?.ToString();
                                    entity.UseDepartment = row["使用部门"]?.ToString();
                                    entity.UseState = row["使用状态"]?.ToString();
                                    entity.UseDate = row["使用年限"]?.ToString();
                                    entity.UsePlace = row["使用地点"]?.ToString();
                                    entity.InstallationDate = Convert.ToDateTime(row["安装日期"]?.ToString()).ToLongDateString();
                                    list.Add(entity);
                                }
                               
                                using (var db = new AssetsInformationDB(dbPath))
                                {
                                    int count = db.InsertAll(list);                        
                                    FrmTips.ShowTips(this, $"{DateTime.Now}, 导入{count}条记录", 3000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Large, new Size(300, 100), TipsState.Success);
                                }
                            }
                        }
                    }
                }

                if (dt != null)
                {
                   
                }
            }

        }
    }

    
}

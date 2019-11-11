using HZH_Controls.Controls;
using HZH_Controls.Forms;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinForm.Common;
using WinForm.DAL;
using WinForm.Model;

namespace WinForm.UI
{
    public partial class FormMain : FrmWithTitle
    {
        string dbPath = $"{Environment.CurrentDirectory}\\AssetsInformation.db";
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            List<DataGridViewColumnEntity> lstCulumns = new List<DataGridViewColumnEntity>();
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "id", HeadText = "序号", Width = 70, WidthType = SizeType.Absolute });
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

            GetList();

        }

        private void BtnAdd_BtnClick(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit();
            formEdit.RefreshActionn = () =>
            {
                GetList();
            };
            formEdit.ShowDialog();
        }

        private void BtnImport_BtnClick(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel表格|*.xlsx";
            fileDialog.CheckFileExists = true;
            if (fileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fileDialog.FileName))
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
                                    var source = db.Query<AssetsInformation>("select * from assetsinformation");
                                    DataGrid.DataSource = source;
                                    DataGrid.ReloadSource();
                                    FrmTips.ShowTips(this, $"导入{count}条记录", 3000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Large, new Size(300, 100), TipsState.Success);
                                }

                            }
                        }
                    }
                }


            }

        }

        private void BtnCreateQr_BtnClick(object sender, EventArgs e)
        {
            var rows = DataGrid.SelectRows;
            if (rows != null)
            {
                var ids = string.Empty;
                rows.ForEach(p => ids += $"{((AssetsInformation)((UCDataGridViewRow)p).DataSource).id},");
                ids = ids.TrimEnd(',');
                using (var db = new AssetsInformationDB(dbPath))
                {
                    var list = db.Query<AssetsInformation>($"select * from assetsinformation where id in ({ids})");
                    if (list != null && list.Any())
                    {
                        foreach (var item in list)
                        {
                            item.QdPath = QRCodeHelper.CreateQRCodeImage(new QRCodeMsg()
                            {
                                Content = $"{item.AssetName}\r\n{item.AssetCode}\r\n{item.AssetModel}\r\n{item.ManagementDepartment}\r\n{item.UseDepartment}\r\n{item.UseState}\r\n{item.UseDate}\r\n{item.UsePlace}\r\n{item.InstallationDate}",
                                ImageName = $"{item.AssetCode}{DateTime.Now.ToLongDateString()}",
                                FilePath = $"{Environment.CurrentDirectory}"
                            });
                        }
                        db.UpdateAll(list);
                    }
                }
                FrmTips.ShowTips(this, $"二维码生成成功！", 3000, true, ContentAlignment.MiddleCenter, null,
                    TipsSizeMode.Large, new Size(200, 80), TipsState.Success);
                GetList();
            }
        }

        private void BtnExport_BtnClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel(*.xlsx)|*.xlsx";
            saveFileDialog.Title = "保存文件路径及名称";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //ExportToExcel(List<string> columnList, DataTable source);
                //MessageBox.Show("选中日期数据已经成功保存至Excel！", "保存Excel提示.", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                //MessageBox.Show("保存操作被取消");
            }
        }

        private void BtnSearch_BtnClick(object sender, EventArgs e)
        {
            GetList(TxtSearch.Text.Trim());
        }
                
        private void BtnEdit_BtnClick(object sender, EventArgs e)
        {
            var row = DataGrid.SelectRows;
            if (row == null || row.Count == 0 || row.Count > 1)
            {
                FrmTips.ShowTips(this, "请选择记录进行修改！", 3000, true, ContentAlignment.MiddleCenter, null,TipsSizeMode.Large, new Size(150, 80), TipsState.Warning);

            }
            else
            {
                FormEdit formEdit = new FormEdit();
                var source = (AssetsInformation)((UCDataGridViewRow)row[0]).DataSource;
                formEdit.Item = source;
                formEdit.RefreshActionn = () =>
                {
                    GetList();
                };
                formEdit.ShowDialog();
            }
        }

        private void BtnDel_BtnClick(object sender, EventArgs e)
        {

           var result= FrmDialog.ShowDialog(this,"确定删除选择的记录？","删除记录",true);
            if(result == DialogResult.OK)
            {
                var rows = DataGrid.SelectRows;

                if (rows != null)
                {
                    var ids = string.Empty;
                    rows.ForEach(p => ids += $"{((AssetsInformation)((UCDataGridViewRow)p).DataSource).id},");
                    ids = ids.TrimEnd(',');
                    using (var db = new AssetsInformationDB(dbPath))
                    {
                        db.Query<AssetsInformation>($"delete from assetsinformation where id in ({ids})");
                    }

                    FrmTips.ShowTips(this, $"删除成功！", 3000, true, ContentAlignment.MiddleCenter, null,
                        TipsSizeMode.Large, new Size(200, 80), TipsState.Success);
                    GetList();
                }
            }
            
        }

        private void GetList(string searchStr="")
        {
            using (var db = new AssetsInformationDB(dbPath))
            {
                List<AssetsInformation> source = new List<AssetsInformation>();
                if (!string.IsNullOrWhiteSpace(searchStr))
                {
                    source = db.Query<AssetsInformation>($"select * from assetsinformation where AssetName like '%{searchStr}%'");
                }
                else
                {
                    source = db.Query<AssetsInformation>("select * from assetsinformation");
                }
                DataGrid.DataSource = source;
                DataGrid.ReloadSource();
            }
        }

        private void BtnPrintQr_BtnClick(object sender, EventArgs e)
        {

        }

        private void BtnLog_BtnClick(object sender, EventArgs e)
        {

        }
    }

    
}

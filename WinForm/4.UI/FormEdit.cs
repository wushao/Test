using HZH_Controls.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinForm.DAL;
using WinForm.Model;

namespace WinForm.UI
{
    public partial class FormEdit : FrmWithOKCancel2
    {
        string dbPath = $"{Environment.CurrentDirectory}\\AssetsInformation.db";

        public  Action RefreshActionn { get; set; }
        public FormEdit()
        {
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            panel3.Controls.Add(new WinUserControl.FormUserControl());
        }

        protected override void DoEnter()
        {
            AssetsInformation model = new AssetsInformation();
            
            var txtAssetName = panel3.Controls.Find("TxtAssetName", true).FirstOrDefault();
            if (txtAssetName!=null)
            {
                model.AssetName = txtAssetName.Text;
            }
            var txtAssetCode =panel3.Controls.Find("TxtAssetCode", true).FirstOrDefault();
            if (txtAssetCode != null)
            {
                model.AssetCode = txtAssetCode.Text;
            }
            var txtAssetModel= panel3.Controls.Find("TxtAssetModel", true).FirstOrDefault();
            if (txtAssetModel != null)
            {
                model.AssetModel = txtAssetModel.Text;
            }
            var txtManagementDepartment= panel3.Controls.Find("TxtManagementDepartment", true).FirstOrDefault();
            if (txtManagementDepartment != null)
            {
                model.ManagementDepartment = txtManagementDepartment.Text;
            }
            var txtUseDepartment =  panel3.Controls.Find("TxtUseDepartment", true).FirstOrDefault();
            if (txtUseDepartment != null)
            {
                model.UseDepartment = txtUseDepartment.Text;
            }
            var comUseState= panel3.Controls.Find("ComUseState", true).FirstOrDefault();
            if (comUseState != null)
            {
                model.UseState = comUseState.Text;
            }
            var txtUseDate = panel3.Controls.Find("TxtUseDate", true).FirstOrDefault();
            if (txtUseDate != null)
            {
                model.UseDate = txtUseDate.Text;
            }
            var txtUsePlace= panel3.Controls.Find("TxtUsePlace", true).FirstOrDefault();
            if (txtUsePlace != null)
            {
                model.UsePlace = txtUsePlace.Text;
            }

            //panel3.Controls.Find("DPInstallationDate", false);

            using (var db = new AssetsInformationDB(dbPath))
            {
                var list = db.Insert(model);
                RefreshActionn();
                FrmTips.ShowTips(this, $"{DateTime.Now}, 新增成功！", 3000, true, ContentAlignment.MiddleCenter, null, TipsSizeMode.Large, new Size(200, 80), TipsState.Success);
                this.Close();
            }
        }
    }
}

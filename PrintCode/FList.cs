using HZH_Controls;
using HZH_Controls.Forms;
using PrintCode.UserCtrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintCode
{
    public partial class FList : FrmWithTitle
    {
        public FList()
        {
            InitializeComponent();
        }

        private void FList_Load(object sender, EventArgs e)
        {
            try
            {
               
                ControlHelper.FreezeControl(this, true);
                PanlList.Controls.Clear();
                UCActionBtn btnList = new UCActionBtn();
                PanlList.Controls.Add(btnList);
                UCGridTable grid = new UCGridTable();
                panel2.Controls.Add(grid);
                var cls = this.Controls.Find("ucDataGridView1", true);
               
            }
            finally
            {
                ControlHelper.FreezeControl(this, false);
            }
        }

        
    }
}

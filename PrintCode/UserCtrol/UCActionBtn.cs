using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintCode.UserCtrol
{
    public partial class UCActionBtn : UserControl
    {
        public UCActionBtn()
        {
            InitializeComponent();
        }

        private void BtnAdd_BtnClick(object sender, EventArgs e)
        {
            FEdit fEdit = new FEdit();
            fEdit.ShowDialog(this);
        }
    }
}

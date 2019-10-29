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

    public partial class FEdit : HZH_Controls.Forms.FrmWithOKCancel2
    {
        public FEdit()
        {
            InitializeComponent();
            ucTextBoxEx1.InputText = "123";
        }

        protected override void DoEnter()
        {
            string text = ucTextBoxEx1.InputText;
            MessageBox.Show(text);
            DateTime dt = ucDatePickerExt1.CurrentTime;
            MessageBox.Show(dt.ToString());
        }
    }
}

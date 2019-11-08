using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinForm.UI.WinUserControl
{
    public partial class FormUserControl : UserControl
    {
        public FormUserControl()
        {
            InitializeComponent();
        }

        private void FormUserControl_Load(object sender, EventArgs e)
        {

            List<KeyValuePair<string, string>> lstCom = new List<KeyValuePair<string, string>>();
            lstCom.Add(new KeyValuePair<string, string>("在职", "在职"));
            lstCom.Add(new KeyValuePair<string, string>("离职", "离职"));
            this.ComUseState.Source = lstCom;
            ComUseState.SelectedIndex = 0;
        }
    }
}

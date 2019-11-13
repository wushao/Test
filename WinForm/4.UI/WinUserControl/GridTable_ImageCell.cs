using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Model;

namespace WinForm.UI.WinUserControl
{
    public partial class GridTable_ImageCell : UserControl, HZH_Controls.Controls.IDataGridViewCustomCell
    {
        public GridTable_ImageCell()
        {
            InitializeComponent();
        }

        public void SetBindSource(object obj)
        {
            if (obj is AssetsInformation)
            {
                var path = (obj as AssetsInformation).QdPath;
                this.BackgroundImage = Image.FromFile(path);
            }
        }
    }
}

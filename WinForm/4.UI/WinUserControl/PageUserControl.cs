using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HZH_Controls.Controls;

namespace WinForm.UI.WinUserControl
{
    public partial class PageUserControl : UCPagerControlBase
    {
        public PageUserControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 数据来源
        /// </summary>
        public SourceModel SourceModel { get; set; }

        /// <summary>
        /// 下一页条数
        /// </summary>
        public int NextPageSize { get; set; }
        public override List<object> GetCurrentSource()
        {
            if (SourceModel == SourceModel.FromList)
            {
                return base.GetCurrentSource();
            }
            else
            {
                if (DataSource == null || DataSource.Count <= 0)
                    return null;
                int intShowCount = PageSize;
                if (intShowCount > NextPageSize)
                    intShowCount = NextPageSize;
                object[] objs = new object[intShowCount];
                bool blnLeft = false;
                bool blnRight = false;
                if (NextPageSize > 0)
                {
                    blnRight = true;
                }
                else
                {
                    blnRight = false;
                }
                if (PageIndex > 1)
                {
                    blnLeft = true;
                }
                else
                {
                    blnLeft = false;
                }
                
                ShowBtn(blnLeft, blnRight);
                return DataSource;
            }
        }
    }
}

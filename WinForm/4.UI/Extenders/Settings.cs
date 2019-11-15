using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Properties;
using WinForm.UI.Forms;
using static WinForm.UI.Forms.HeaderTableLayoutPanel;

namespace WinForm.UI.Extenders
{
    public static class Settings
    {
        /// <summary>
        /// Setting the main form of the application that is used for showing Dialogs and Information forms
        /// </summary>
        /// <param name="MainWindow">the main form</param>
        public static void SetMainForm(IWin32Window MainWindow)
        {
            FormServices.MainWindow = MainWindow;
        }

        /// <summary>
        /// Images that is used for generating
        /// </summary>
        public static class Images
        {
            private static Bitmap selectRowImage = Resources.SelectRowImage;
            public static Bitmap SelectRowImage
            {
                get { return Images.selectRowImage; }
                set { if (value != null) Images.selectRowImage = value; }
            }

            private static Bitmap clearFieldImage = Resources.ClearFieldImage;
            public static Bitmap ClearFieldImage
            {
                get { return Images.clearFieldImage; }
                set { if (value != null) Images.clearFieldImage = value; }
            }
        }

        /// <summary>
        /// Settings for generation HeaderTableLayoutPanel on the panels
        /// </summary>
        public static class HeaderTableLayoutPanel
        {
            public static HighlightCaptionStyle CaptionStyle { get; set; } = HighlightCaptionStyle.NavisionAxaptaStyle;
            public static byte CaptionLineWidth { get; set; } = 2;
        }

    }
}

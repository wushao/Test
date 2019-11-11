namespace WinForm.UI
{
    partial class FormLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucPanelQuote1 = new HZH_Controls.Controls.UCPanelQuote();
            this.DataGrid = new HZH_Controls.Controls.UCDataGridView();
            this.ucPanelQuote1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPanelQuote1
            // 
            this.ucPanelQuote1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucPanelQuote1.Controls.Add(this.DataGrid);
            this.ucPanelQuote1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanelQuote1.LeftColor = System.Drawing.Color.Green;
            this.ucPanelQuote1.Location = new System.Drawing.Point(0, 61);
            this.ucPanelQuote1.Name = "ucPanelQuote1";
            this.ucPanelQuote1.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.ucPanelQuote1.Size = new System.Drawing.Size(486, 389);
            this.ucPanelQuote1.TabIndex = 7;
            // 
            // DataGrid
            // 
            this.DataGrid.AutoScroll = true;
            this.DataGrid.BackColor = System.Drawing.Color.White;
            this.DataGrid.Columns = null;
            this.DataGrid.DataSource = null;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.HeadFont = new System.Drawing.Font("微软雅黑", 12F);
            this.DataGrid.HeadHeight = 40;
            this.DataGrid.HeadPadingLeft = 0;
            this.DataGrid.HeadTextColor = System.Drawing.Color.Black;
            this.DataGrid.IsShowCheckBox = false;
            this.DataGrid.IsShowHead = true;
            this.DataGrid.Location = new System.Drawing.Point(5, 1);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeight = 40;
            this.DataGrid.RowType = typeof(HZH_Controls.Controls.UCDataGridViewRow);
            this.DataGrid.Size = new System.Drawing.Size(480, 387);
            this.DataGrid.TabIndex = 0;
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyleColor = System.Drawing.Color.Green;
            this.BorderStyleSize = 2;
            this.BorderStyleType = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.ucPanelQuote1);
            this.IsShowCloseBtn = true;
            this.Name = "FormLog";
            this.Text = "FormLog";
            this.Title = "日志记录";
            this.Controls.SetChildIndex(this.ucPanelQuote1, 0);
            this.ucPanelQuote1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCPanelQuote ucPanelQuote1;
        private HZH_Controls.Controls.UCDataGridView DataGrid;
    }
}
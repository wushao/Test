namespace PrintCode
{
    partial class FList
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PanlList = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanlList
            // 
            this.PanlList.BackColor = System.Drawing.Color.White;
            this.PanlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanlList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanlList.Location = new System.Drawing.Point(0, 61);
            this.PanlList.Name = "PanlList";
            this.PanlList.Size = new System.Drawing.Size(600, 125);
            this.PanlList.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 314);
            this.panel2.TabIndex = 8;
            // 
            // FList
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyleColor = System.Drawing.Color.DimGray;
            this.BorderStyleSize = 1;
            this.BorderStyleType = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PanlList);
            this.IsShowCloseBtn = true;
            this.Name = "FList";
            this.Title = "信息列表";
            this.Load += new System.EventHandler(this.FList_Load);
            this.Controls.SetChildIndex(this.PanlList, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanlList;
        private System.Windows.Forms.Panel panel2;
    }
}


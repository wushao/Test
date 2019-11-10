namespace WinForm.UI
{
    partial class FormPrint
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
            this.ucCombox1 = new HZH_Controls.Controls.UCCombox();
            this.LabPrintList = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LabPrintList);
            this.panel3.Controls.Add(this.ucCombox1);
            this.panel3.Size = new System.Drawing.Size(300, 90);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 151);
            this.panel2.Size = new System.Drawing.Size(300, 64);
            // 
            // ucCombox1
            // 
            this.ucCombox1.BackColor = System.Drawing.Color.Transparent;
            this.ucCombox1.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucCombox1.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ucCombox1.ConerRadius = 5;
            this.ucCombox1.DropPanelHeight = -1;
            this.ucCombox1.FillColor = System.Drawing.Color.White;
            this.ucCombox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ucCombox1.IsRadius = true;
            this.ucCombox1.IsShowRect = true;
            this.ucCombox1.ItemWidth = 70;
            this.ucCombox1.Location = new System.Drawing.Point(77, 27);
            this.ucCombox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucCombox1.Name = "ucCombox1";
            this.ucCombox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucCombox1.RectWidth = 1;
            this.ucCombox1.SelectedIndex = -1;
            this.ucCombox1.SelectedValue = "";
            this.ucCombox1.Size = new System.Drawing.Size(173, 32);
            this.ucCombox1.Source = null;
            this.ucCombox1.TabIndex = 0;
            this.ucCombox1.TextValue = "";
            this.ucCombox1.TriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            // 
            // LabPrintList
            // 
            this.LabPrintList.AutoSize = true;
            this.LabPrintList.Location = new System.Drawing.Point(12, 35);
            this.LabPrintList.Name = "LabPrintList";
            this.LabPrintList.Size = new System.Drawing.Size(56, 17);
            this.LabPrintList.TabIndex = 1;
            this.LabPrintList.Text = "打印列表";
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 215);
            this.IsShowCloseBtn = true;
            this.Name = "FormPrint";
            this.Text = "FormPrint";
            this.Title = "打印";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabPrintList;
        private HZH_Controls.Controls.UCCombox ucCombox1;
    }
}
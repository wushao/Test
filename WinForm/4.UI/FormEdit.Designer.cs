namespace WinForm.UI
{
    partial class FormEdit
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
            this.ucDatePickerExt1 = new HZH_Controls.Controls.UCDatePickerExt();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucDatePickerExt1);
            this.panel3.Size = new System.Drawing.Size(411, 316);
            this.panel3.Size = new System.Drawing.Size(584, 316);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 556);
            this.panel2.Size = new System.Drawing.Size(411, 64);
            // 
            // ucDatePickerExt1
            // 
            this.ucDatePickerExt1.BackColor = System.Drawing.Color.Transparent;
            this.ucDatePickerExt1.ConerRadius = 5;
            this.ucDatePickerExt1.CurrentTime = new System.DateTime(2019, 10, 29, 16, 37, 56, 0);
            this.ucDatePickerExt1.FillColor = System.Drawing.Color.Transparent;
            this.ucDatePickerExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucDatePickerExt1.ForeColor = System.Drawing.Color.Black;
            this.ucDatePickerExt1.IsRadius = true;
            this.ucDatePickerExt1.IsShowRect = true;
            this.ucDatePickerExt1.Location = new System.Drawing.Point(26, 247);
            this.ucDatePickerExt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucDatePickerExt1.Name = "ucDatePickerExt1";
            this.ucDatePickerExt1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ucDatePickerExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucDatePickerExt1.RectWidth = 1;
            this.ucDatePickerExt1.Size = new System.Drawing.Size(219, 39);
            this.ucDatePickerExt1.TabIndex = 0;
            this.ucDatePickerExt1.TimeFontSize = 20;
            this.ucDatePickerExt1.TimeType = HZH_Controls.Controls.DateTimePickerType.Date;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyleColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(411, 441);
            this.IsShowCloseBtn = true;
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCDatePickerExt ucDatePickerExt1;
    }
}
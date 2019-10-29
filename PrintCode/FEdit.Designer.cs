namespace PrintCode
{
    partial class FEdit
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
            this.ucTextBoxEx1 = new HZH_Controls.Controls.UCTextBoxEx();
            this.ucDatePickerExt1 = new HZH_Controls.Controls.UCDatePickerExt();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucDatePickerExt1);
            this.panel3.Controls.Add(this.ucTextBoxEx1);
            // 
            // ucTextBoxEx1
            // 
            this.ucTextBoxEx1.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxEx1.ConerRadius = 5;
            this.ucTextBoxEx1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxEx1.DecLength = 2;
            this.ucTextBoxEx1.FillColor = System.Drawing.Color.Empty;
            this.ucTextBoxEx1.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTextBoxEx1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx1.InputText = "";
            this.ucTextBoxEx1.InputType = HZH_Controls.TextInputType.NotControl;
            this.ucTextBoxEx1.IsFocusColor = true;
            this.ucTextBoxEx1.IsRadius = true;
            this.ucTextBoxEx1.IsShowClearBtn = true;
            this.ucTextBoxEx1.IsShowKeyboard = false;
            this.ucTextBoxEx1.IsShowRect = true;
            this.ucTextBoxEx1.IsShowSearchBtn = false;
            this.ucTextBoxEx1.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxEx1.Location = new System.Drawing.Point(41, 54);
            this.ucTextBoxEx1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxEx1.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucTextBoxEx1.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.ucTextBoxEx1.Name = "ucTextBoxEx1";
            this.ucTextBoxEx1.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxEx1.PromptColor = System.Drawing.Color.Gray;
            this.ucTextBoxEx1.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxEx1.PromptText = "123";
            this.ucTextBoxEx1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucTextBoxEx1.RectWidth = 1;
            this.ucTextBoxEx1.RegexPattern = "";
            this.ucTextBoxEx1.Size = new System.Drawing.Size(322, 30);
            this.ucTextBoxEx1.TabIndex = 0;
            // 
            // ucDatePickerExt1
            // 
            this.ucDatePickerExt1.BackColor = System.Drawing.Color.Transparent;
            this.ucDatePickerExt1.ConerRadius = 5;
            this.ucDatePickerExt1.CurrentTime = new System.DateTime(2019, 10, 27, 0, 48, 0, 0);
            this.ucDatePickerExt1.FillColor = System.Drawing.Color.Transparent;
            this.ucDatePickerExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucDatePickerExt1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ucDatePickerExt1.IsRadius = true;
            this.ucDatePickerExt1.IsShowRect = true;
            this.ucDatePickerExt1.Location = new System.Drawing.Point(41, 109);
            this.ucDatePickerExt1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucDatePickerExt1.Name = "ucDatePickerExt1";
            this.ucDatePickerExt1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ucDatePickerExt1.RectColor = System.Drawing.Color.Black;
            this.ucDatePickerExt1.RectWidth = 1;
            this.ucDatePickerExt1.Size = new System.Drawing.Size(335, 39);
            this.ucDatePickerExt1.TabIndex = 1;
            this.ucDatePickerExt1.TimeFontSize = 10;
            this.ucDatePickerExt1.TimeType = HZH_Controls.Controls.DateTimePickerType.DateTime;
            // 
            // FEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 310);
            this.Name = "FEdit";
            this.Text = "FEdit";
            this.Title = "编辑";
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxEx1;
        private HZH_Controls.Controls.UCDatePickerExt ucDatePickerExt1;
    }
}
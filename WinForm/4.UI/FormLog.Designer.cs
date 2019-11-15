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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.ucPanelQuote1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPanelQuote1
            // 
            this.ucPanelQuote1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucPanelQuote1.Controls.Add(this.DataGrid);
            this.ucPanelQuote1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanelQuote1.LeftColor = System.Drawing.Color.Green;
            this.ucPanelQuote1.Location = new System.Drawing.Point(20, 63);
            this.ucPanelQuote1.Name = "ucPanelQuote1";
            this.ucPanelQuote1.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.ucPanelQuote1.Size = new System.Drawing.Size(760, 367);
            this.ucPanelQuote1.TabIndex = 0;
            // 
            // DataGrid
            // 
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGrid.Location = new System.Drawing.Point(5, 1);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowTemplate.Height = 23;
            this.DataGrid.Size = new System.Drawing.Size(754, 365);
            this.DataGrid.TabIndex = 0;
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucPanelQuote1);
            this.Name = "FormLog";
            this.Text = "日志信息";
            this.Load += new System.EventHandler(this.FormLog_Load);
            this.ucPanelQuote1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCPanelQuote ucPanelQuote1;
        private System.Windows.Forms.DataGridView DataGrid;
    }
}
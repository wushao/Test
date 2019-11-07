namespace WinForm.UI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ucPanelQuote1 = new HZH_Controls.Controls.UCPanelQuote();
            this.BtnLog = new HZH_Controls.Controls.UCBtnExt();
            this.BtnPrintQr = new HZH_Controls.Controls.UCBtnExt();
            this.BtnCreateQr = new HZH_Controls.Controls.UCBtnExt();
            this.BtnExport = new HZH_Controls.Controls.UCBtnExt();
            this.BtnImport = new HZH_Controls.Controls.UCBtnExt();
            this.BtnDel = new HZH_Controls.Controls.UCBtnExt();
            this.BtnEdit = new HZH_Controls.Controls.UCBtnExt();
            this.BtnAdd = new HZH_Controls.Controls.UCBtnExt();
            this.ucPanelQuote2 = new HZH_Controls.Controls.UCPanelQuote();
            this.BtnSearch = new HZH_Controls.Controls.UCBtnExt();
            this.ucDropDownBtn1 = new HZH_Controls.Controls.UCDropDownBtn();
            this.textBoxEx1 = new HZH_Controls.Controls.TextBoxEx();
            this.ucPanelQuote3 = new HZH_Controls.Controls.UCPanelQuote();
            this.DataGrid = new HZH_Controls.Controls.UCDataGridView();
            this.ucPanelQuote1.SuspendLayout();
            this.ucPanelQuote2.SuspendLayout();
            this.ucPanelQuote3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPanelQuote1
            // 
            this.ucPanelQuote1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucPanelQuote1.BorderColor = System.Drawing.Color.Green;
            this.ucPanelQuote1.Controls.Add(this.BtnLog);
            this.ucPanelQuote1.Controls.Add(this.BtnPrintQr);
            this.ucPanelQuote1.Controls.Add(this.BtnCreateQr);
            this.ucPanelQuote1.Controls.Add(this.BtnExport);
            this.ucPanelQuote1.Controls.Add(this.BtnImport);
            this.ucPanelQuote1.Controls.Add(this.BtnDel);
            this.ucPanelQuote1.Controls.Add(this.BtnEdit);
            this.ucPanelQuote1.Controls.Add(this.BtnAdd);
            this.ucPanelQuote1.LeftColor = System.Drawing.Color.Green;
            this.ucPanelQuote1.Location = new System.Drawing.Point(5, 67);
            this.ucPanelQuote1.Name = "ucPanelQuote1";
            this.ucPanelQuote1.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.ucPanelQuote1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ucPanelQuote1.Size = new System.Drawing.Size(864, 50);
            this.ucPanelQuote1.TabIndex = 7;
            // 
            // BtnLog
            // 
            this.BtnLog.BackColor = System.Drawing.Color.White;
            this.BtnLog.BtnBackColor = System.Drawing.Color.White;
            this.BtnLog.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLog.BtnForeColor = System.Drawing.Color.White;
            this.BtnLog.BtnText = "查看日志";
            this.BtnLog.ConerRadius = 5;
            this.BtnLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLog.FillColor = System.Drawing.Color.ForestGreen;
            this.BtnLog.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnLog.IsRadius = true;
            this.BtnLog.IsShowRect = true;
            this.BtnLog.IsShowTips = false;
            this.BtnLog.Location = new System.Drawing.Point(605, 12);
            this.BtnLog.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.BtnLog.RectColor = System.Drawing.Color.Green;
            this.BtnLog.RectWidth = 1;
            this.BtnLog.Size = new System.Drawing.Size(90, 28);
            this.BtnLog.TabIndex = 2;
            this.BtnLog.TabStop = false;
            this.BtnLog.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BtnLog.TipsText = "";
            // 
            // BtnPrintQr
            // 
            this.BtnPrintQr.BackColor = System.Drawing.Color.White;
            this.BtnPrintQr.BtnBackColor = System.Drawing.Color.White;
            this.BtnPrintQr.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPrintQr.BtnForeColor = System.Drawing.Color.White;
            this.BtnPrintQr.BtnText = "打印二维码";
            this.BtnPrintQr.ConerRadius = 5;
            this.BtnPrintQr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrintQr.FillColor = System.Drawing.Color.ForestGreen;
            this.BtnPrintQr.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnPrintQr.IsRadius = true;
            this.BtnPrintQr.IsShowRect = true;
            this.BtnPrintQr.IsShowTips = false;
            this.BtnPrintQr.Location = new System.Drawing.Point(500, 12);
            this.BtnPrintQr.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPrintQr.Name = "BtnPrintQr";
            this.BtnPrintQr.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnPrintQr.RectColor = System.Drawing.Color.Green;
            this.BtnPrintQr.RectWidth = 1;
            this.BtnPrintQr.Size = new System.Drawing.Size(87, 28);
            this.BtnPrintQr.TabIndex = 2;
            this.BtnPrintQr.TabStop = false;
            this.BtnPrintQr.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BtnPrintQr.TipsText = "";
            // 
            // BtnCreateQr
            // 
            this.BtnCreateQr.BackColor = System.Drawing.Color.White;
            this.BtnCreateQr.BtnBackColor = System.Drawing.Color.White;
            this.BtnCreateQr.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnCreateQr.BtnForeColor = System.Drawing.Color.White;
            this.BtnCreateQr.BtnText = "生成二维码";
            this.BtnCreateQr.ConerRadius = 5;
            this.BtnCreateQr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreateQr.FillColor = System.Drawing.Color.ForestGreen;
            this.BtnCreateQr.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnCreateQr.IsRadius = true;
            this.BtnCreateQr.IsShowRect = true;
            this.BtnCreateQr.IsShowTips = false;
            this.BtnCreateQr.Location = new System.Drawing.Point(397, 12);
            this.BtnCreateQr.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCreateQr.Name = "BtnCreateQr";
            this.BtnCreateQr.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BtnCreateQr.RectColor = System.Drawing.Color.Green;
            this.BtnCreateQr.RectWidth = 1;
            this.BtnCreateQr.Size = new System.Drawing.Size(86, 28);
            this.BtnCreateQr.TabIndex = 2;
            this.BtnCreateQr.TabStop = false;
            this.BtnCreateQr.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BtnCreateQr.TipsText = "";
            // 
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.Color.White;
            this.BtnExport.BtnBackColor = System.Drawing.Color.White;
            this.BtnExport.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnExport.BtnForeColor = System.Drawing.Color.White;
            this.BtnExport.BtnText = "导出";
            this.BtnExport.ConerRadius = 5;
            this.BtnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExport.FillColor = System.Drawing.Color.ForestGreen;
            this.BtnExport.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnExport.IsRadius = true;
            this.BtnExport.IsShowRect = true;
            this.BtnExport.IsShowTips = false;
            this.BtnExport.Location = new System.Drawing.Point(313, 12);
            this.BtnExport.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.RectColor = System.Drawing.Color.Green;
            this.BtnExport.RectWidth = 1;
            this.BtnExport.Size = new System.Drawing.Size(58, 28);
            this.BtnExport.TabIndex = 2;
            this.BtnExport.TabStop = false;
            this.BtnExport.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BtnExport.TipsText = "";
            // 
            // BtnImport
            // 
            this.BtnImport.BackColor = System.Drawing.Color.White;
            this.BtnImport.BtnBackColor = System.Drawing.Color.White;
            this.BtnImport.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnImport.BtnForeColor = System.Drawing.Color.White;
            this.BtnImport.BtnText = "导入";
            this.BtnImport.ConerRadius = 5;
            this.BtnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImport.FillColor = System.Drawing.Color.ForestGreen;
            this.BtnImport.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnImport.IsRadius = true;
            this.BtnImport.IsShowRect = true;
            this.BtnImport.IsShowTips = false;
            this.BtnImport.Location = new System.Drawing.Point(241, 12);
            this.BtnImport.Margin = new System.Windows.Forms.Padding(0);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.RectColor = System.Drawing.Color.Green;
            this.BtnImport.RectWidth = 1;
            this.BtnImport.Size = new System.Drawing.Size(58, 28);
            this.BtnImport.TabIndex = 2;
            this.BtnImport.TabStop = false;
            this.BtnImport.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BtnImport.TipsText = "";
            this.BtnImport.BtnClick += new System.EventHandler(this.BtnImport_BtnClick);
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.Color.White;
            this.BtnDel.BtnBackColor = System.Drawing.Color.White;
            this.BtnDel.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnDel.BtnForeColor = System.Drawing.Color.White;
            this.BtnDel.BtnText = "删除";
            this.BtnDel.ConerRadius = 5;
            this.BtnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDel.FillColor = System.Drawing.Color.ForestGreen;
            this.BtnDel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnDel.IsRadius = true;
            this.BtnDel.IsShowRect = true;
            this.BtnDel.IsShowTips = false;
            this.BtnDel.Location = new System.Drawing.Point(163, 12);
            this.BtnDel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.RectColor = System.Drawing.Color.Green;
            this.BtnDel.RectWidth = 1;
            this.BtnDel.Size = new System.Drawing.Size(58, 28);
            this.BtnDel.TabIndex = 2;
            this.BtnDel.TabStop = false;
            this.BtnDel.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BtnDel.TipsText = "";
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.White;
            this.BtnEdit.BtnBackColor = System.Drawing.Color.White;
            this.BtnEdit.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnEdit.BtnForeColor = System.Drawing.Color.White;
            this.BtnEdit.BtnText = "修改";
            this.BtnEdit.ConerRadius = 5;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FillColor = System.Drawing.Color.ForestGreen;
            this.BtnEdit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnEdit.IsRadius = true;
            this.BtnEdit.IsShowRect = true;
            this.BtnEdit.IsShowTips = false;
            this.BtnEdit.Location = new System.Drawing.Point(92, 12);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.RectColor = System.Drawing.Color.Green;
            this.BtnEdit.RectWidth = 1;
            this.BtnEdit.Size = new System.Drawing.Size(58, 28);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.TabStop = false;
            this.BtnEdit.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BtnEdit.TipsText = "";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.White;
            this.BtnAdd.BtnBackColor = System.Drawing.Color.White;
            this.BtnAdd.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAdd.BtnForeColor = System.Drawing.Color.White;
            this.BtnAdd.BtnText = "新增";
            this.BtnAdd.ConerRadius = 5;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FillColor = System.Drawing.Color.ForestGreen;
            this.BtnAdd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnAdd.IsRadius = true;
            this.BtnAdd.IsShowRect = true;
            this.BtnAdd.IsShowTips = false;
            this.BtnAdd.Location = new System.Drawing.Point(20, 12);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.RectColor = System.Drawing.Color.Green;
            this.BtnAdd.RectWidth = 1;
            this.BtnAdd.Size = new System.Drawing.Size(58, 28);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.TabStop = false;
            this.BtnAdd.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BtnAdd.TipsText = "";
            this.BtnAdd.BtnClick += new System.EventHandler(this.BtnAdd_BtnClick);
            // 
            // ucPanelQuote2
            // 
            this.ucPanelQuote2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucPanelQuote2.BorderColor = System.Drawing.Color.Green;
            this.ucPanelQuote2.Controls.Add(this.BtnSearch);
            this.ucPanelQuote2.Controls.Add(this.ucDropDownBtn1);
            this.ucPanelQuote2.Controls.Add(this.textBoxEx1);
            this.ucPanelQuote2.LeftColor = System.Drawing.Color.Green;
            this.ucPanelQuote2.Location = new System.Drawing.Point(5, 123);
            this.ucPanelQuote2.Name = "ucPanelQuote2";
            this.ucPanelQuote2.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.ucPanelQuote2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ucPanelQuote2.Size = new System.Drawing.Size(864, 50);
            this.ucPanelQuote2.TabIndex = 8;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.White;
            this.BtnSearch.BtnBackColor = System.Drawing.Color.White;
            this.BtnSearch.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSearch.BtnForeColor = System.Drawing.Color.White;
            this.BtnSearch.BtnText = "查询";
            this.BtnSearch.ConerRadius = 5;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSearch.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnSearch.IsRadius = true;
            this.BtnSearch.IsShowRect = true;
            this.BtnSearch.IsShowTips = false;
            this.BtnSearch.Location = new System.Drawing.Point(785, 12);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.RectColor = System.Drawing.Color.Green;
            this.BtnSearch.RectWidth = 1;
            this.BtnSearch.Size = new System.Drawing.Size(58, 28);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.TabStop = false;
            this.BtnSearch.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BtnSearch.TipsText = "";
            // 
            // ucDropDownBtn1
            // 
            this.ucDropDownBtn1.BackColor = System.Drawing.Color.White;
            this.ucDropDownBtn1.BtnBackColor = System.Drawing.Color.White;
            this.ucDropDownBtn1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucDropDownBtn1.BtnForeColor = System.Drawing.Color.White;
            this.ucDropDownBtn1.Btns = null;
            this.ucDropDownBtn1.BtnText = "选择查询";
            this.ucDropDownBtn1.ConerRadius = 5;
            this.ucDropDownBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucDropDownBtn1.DropPanelHeight = -1;
            this.ucDropDownBtn1.FillColor = System.Drawing.Color.Green;
            this.ucDropDownBtn1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucDropDownBtn1.ForeColor = System.Drawing.Color.White;
            this.ucDropDownBtn1.Image = ((System.Drawing.Image)(resources.GetObject("ucDropDownBtn1.Image")));
            this.ucDropDownBtn1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucDropDownBtn1.ImageFontIcons = null;
            this.ucDropDownBtn1.IsRadius = true;
            this.ucDropDownBtn1.IsShowRect = true;
            this.ucDropDownBtn1.IsShowTips = false;
            this.ucDropDownBtn1.Location = new System.Drawing.Point(20, 13);
            this.ucDropDownBtn1.Margin = new System.Windows.Forms.Padding(2);
            this.ucDropDownBtn1.Name = "ucDropDownBtn1";
            this.ucDropDownBtn1.RectColor = System.Drawing.Color.Green;
            this.ucDropDownBtn1.RectWidth = 1;
            this.ucDropDownBtn1.Size = new System.Drawing.Size(95, 25);
            this.ucDropDownBtn1.TabIndex = 1;
            this.ucDropDownBtn1.TabStop = false;
            this.ucDropDownBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ucDropDownBtn1.TipsColor = System.Drawing.Color.Green;
            this.ucDropDownBtn1.TipsText = "";
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.DecLength = 2;
            this.textBoxEx1.InputType = HZH_Controls.TextInputType.NotControl;
            this.textBoxEx1.Location = new System.Drawing.Point(126, 15);
            this.textBoxEx1.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.textBoxEx1.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.textBoxEx1.MyRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.OldText = null;
            this.textBoxEx1.PromptColor = System.Drawing.Color.Gray;
            this.textBoxEx1.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxEx1.PromptText = "";
            this.textBoxEx1.RegexPattern = "";
            this.textBoxEx1.Size = new System.Drawing.Size(162, 23);
            this.textBoxEx1.TabIndex = 0;
            // 
            // ucPanelQuote3
            // 
            this.ucPanelQuote3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucPanelQuote3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucPanelQuote3.Controls.Add(this.DataGrid);
            this.ucPanelQuote3.LeftColor = System.Drawing.Color.Green;
            this.ucPanelQuote3.Location = new System.Drawing.Point(5, 179);
            this.ucPanelQuote3.Name = "ucPanelQuote3";
            this.ucPanelQuote3.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.ucPanelQuote3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ucPanelQuote3.Size = new System.Drawing.Size(864, 463);
            this.ucPanelQuote3.TabIndex = 8;
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
            this.DataGrid.Size = new System.Drawing.Size(858, 461);
            this.DataGrid.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyleColor = System.Drawing.Color.OliveDrab;
            this.BorderStyleSize = 2;
            this.BorderStyleType = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ClientSize = new System.Drawing.Size(879, 654);
            this.Controls.Add(this.ucPanelQuote3);
            this.Controls.Add(this.ucPanelQuote2);
            this.Controls.Add(this.ucPanelQuote1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsShowCloseBtn = true;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Title = "信息列表";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Controls.SetChildIndex(this.ucPanelQuote1, 0);
            this.Controls.SetChildIndex(this.ucPanelQuote2, 0);
            this.Controls.SetChildIndex(this.ucPanelQuote3, 0);
            this.ucPanelQuote1.ResumeLayout(false);
            this.ucPanelQuote2.ResumeLayout(false);
            this.ucPanelQuote2.PerformLayout();
            this.ucPanelQuote3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCPanelQuote ucPanelQuote1;
        private HZH_Controls.Controls.UCPanelQuote ucPanelQuote2;
        private HZH_Controls.Controls.UCPanelQuote ucPanelQuote3;
        private HZH_Controls.Controls.UCBtnExt BtnLog;
        private HZH_Controls.Controls.UCBtnExt BtnPrintQr;
        private HZH_Controls.Controls.UCBtnExt BtnCreateQr;
        private HZH_Controls.Controls.UCBtnExt BtnExport;
        private HZH_Controls.Controls.UCBtnExt BtnImport;
        private HZH_Controls.Controls.UCBtnExt BtnDel;
        private HZH_Controls.Controls.UCBtnExt BtnEdit;
        private HZH_Controls.Controls.UCBtnExt BtnAdd;
        private HZH_Controls.Controls.UCDropDownBtn ucDropDownBtn1;
        private HZH_Controls.Controls.TextBoxEx textBoxEx1;
        private HZH_Controls.Controls.UCBtnExt BtnSearch;
        private HZH_Controls.Controls.UCDataGridView DataGrid;
    }
}
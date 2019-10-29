namespace PrintCode.UserCtrol
{
    partial class UCActionBtn
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnGroup = new System.Windows.Forms.GroupBox();
            this.BtnPrint = new HZH_Controls.Controls.UCBtnExt();
            this.BtnQrCode = new HZH_Controls.Controls.UCBtnExt();
            this.BtnExport = new HZH_Controls.Controls.UCBtnExt();
            this.BtnImport = new HZH_Controls.Controls.UCBtnExt();
            this.BtnDel = new HZH_Controls.Controls.UCBtnExt();
            this.BtnEdit = new HZH_Controls.Controls.UCBtnExt();
            this.BtnAdd = new HZH_Controls.Controls.UCBtnExt();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new HZH_Controls.Controls.UCBtnExt();
            this.BtnGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGroup
            // 
            this.BtnGroup.Controls.Add(this.BtnPrint);
            this.BtnGroup.Controls.Add(this.BtnQrCode);
            this.BtnGroup.Controls.Add(this.BtnExport);
            this.BtnGroup.Controls.Add(this.BtnImport);
            this.BtnGroup.Controls.Add(this.BtnDel);
            this.BtnGroup.Controls.Add(this.BtnEdit);
            this.BtnGroup.Controls.Add(this.BtnAdd);
            this.BtnGroup.Location = new System.Drawing.Point(10, 4);
            this.BtnGroup.Name = "BtnGroup";
            this.BtnGroup.Size = new System.Drawing.Size(579, 86);
            this.BtnGroup.TabIndex = 0;
            this.BtnGroup.TabStop = false;
            this.BtnGroup.Text = "操作";
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.White;
            this.BtnPrint.BtnBackColor = System.Drawing.Color.White;
            this.BtnPrint.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPrint.BtnForeColor = System.Drawing.Color.White;
            this.BtnPrint.BtnText = "打印二维码";
            this.BtnPrint.ConerRadius = 5;
            this.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrint.FillColor = System.Drawing.Color.Red;
            this.BtnPrint.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnPrint.IsRadius = true;
            this.BtnPrint.IsShowRect = true;
            this.BtnPrint.IsShowTips = false;
            this.BtnPrint.Location = new System.Drawing.Point(138, 53);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.BtnPrint.RectWidth = 1;
            this.BtnPrint.Size = new System.Drawing.Size(80, 30);
            this.BtnPrint.TabIndex = 4;
            this.BtnPrint.TabStop = false;
            this.BtnPrint.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BtnPrint.TipsText = "";
            // 
            // BtnQrCode
            // 
            this.BtnQrCode.BackColor = System.Drawing.Color.White;
            this.BtnQrCode.BtnBackColor = System.Drawing.Color.White;
            this.BtnQrCode.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQrCode.BtnForeColor = System.Drawing.Color.White;
            this.BtnQrCode.BtnText = "生成二维码";
            this.BtnQrCode.ConerRadius = 5;
            this.BtnQrCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQrCode.FillColor = System.Drawing.Color.Red;
            this.BtnQrCode.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnQrCode.IsRadius = true;
            this.BtnQrCode.IsShowRect = true;
            this.BtnQrCode.IsShowTips = false;
            this.BtnQrCode.Location = new System.Drawing.Point(22, 53);
            this.BtnQrCode.Margin = new System.Windows.Forms.Padding(0);
            this.BtnQrCode.Name = "BtnQrCode";
            this.BtnQrCode.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.BtnQrCode.RectWidth = 1;
            this.BtnQrCode.Size = new System.Drawing.Size(80, 30);
            this.BtnQrCode.TabIndex = 3;
            this.BtnQrCode.TabStop = false;
            this.BtnQrCode.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BtnQrCode.TipsText = "";
            // 
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.Color.White;
            this.BtnExport.BtnBackColor = System.Drawing.Color.White;
            this.BtnExport.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnExport.BtnForeColor = System.Drawing.Color.White;
            this.BtnExport.BtnText = "导出数据";
            this.BtnExport.ConerRadius = 5;
            this.BtnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExport.FillColor = System.Drawing.Color.Red;
            this.BtnExport.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnExport.IsRadius = true;
            this.BtnExport.IsShowRect = true;
            this.BtnExport.IsShowTips = false;
            this.BtnExport.Location = new System.Drawing.Point(488, 12);
            this.BtnExport.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.BtnExport.RectWidth = 1;
            this.BtnExport.Size = new System.Drawing.Size(80, 30);
            this.BtnExport.TabIndex = 3;
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
            this.BtnImport.BtnText = "导入数据";
            this.BtnImport.ConerRadius = 5;
            this.BtnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImport.FillColor = System.Drawing.Color.Red;
            this.BtnImport.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnImport.IsRadius = true;
            this.BtnImport.IsShowRect = true;
            this.BtnImport.IsShowTips = false;
            this.BtnImport.Location = new System.Drawing.Point(376, 12);
            this.BtnImport.Margin = new System.Windows.Forms.Padding(0);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.BtnImport.RectWidth = 1;
            this.BtnImport.Size = new System.Drawing.Size(80, 30);
            this.BtnImport.TabIndex = 3;
            this.BtnImport.TabStop = false;
            this.BtnImport.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BtnImport.TipsText = "";
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
            this.BtnDel.FillColor = System.Drawing.Color.Red;
            this.BtnDel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnDel.IsRadius = true;
            this.BtnDel.IsShowRect = true;
            this.BtnDel.IsShowTips = false;
            this.BtnDel.Location = new System.Drawing.Point(264, 12);
            this.BtnDel.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.BtnDel.RectWidth = 1;
            this.BtnDel.Size = new System.Drawing.Size(80, 30);
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
            this.BtnEdit.FillColor = System.Drawing.Color.Red;
            this.BtnEdit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnEdit.IsRadius = true;
            this.BtnEdit.IsShowRect = true;
            this.BtnEdit.IsShowTips = false;
            this.BtnEdit.Location = new System.Drawing.Point(138, 12);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.RectColor = System.Drawing.Color.Red;
            this.BtnEdit.RectWidth = 1;
            this.BtnEdit.Size = new System.Drawing.Size(80, 30);
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
            this.BtnAdd.FillColor = System.Drawing.Color.Red;
            this.BtnAdd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnAdd.IsRadius = true;
            this.BtnAdd.IsShowRect = true;
            this.BtnAdd.IsShowTips = false;
            this.BtnAdd.Location = new System.Drawing.Point(22, 12);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnAdd.RectWidth = 1;
            this.BtnAdd.Size = new System.Drawing.Size(80, 30);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.TabStop = false;
            this.BtnAdd.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BtnAdd.TipsText = "";
            this.BtnAdd.BtnClick += new System.EventHandler(this.BtnAdd_BtnClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Location = new System.Drawing.Point(10, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
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
            this.BtnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.BtnSearch.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnSearch.IsRadius = true;
            this.BtnSearch.IsShowRect = true;
            this.BtnSearch.IsShowTips = false;
            this.BtnSearch.Location = new System.Drawing.Point(489, 15);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.BtnSearch.RectWidth = 1;
            this.BtnSearch.Size = new System.Drawing.Size(80, 30);
            this.BtnSearch.TabIndex = 0;
            this.BtnSearch.TabStop = false;
            this.BtnSearch.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.BtnSearch.TipsText = "";
            // 
            // UCActionBtn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnGroup);
            this.Name = "UCActionBtn";
            this.Size = new System.Drawing.Size(598, 154);
            this.BtnGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BtnGroup;
        private HZH_Controls.Controls.UCBtnExt BtnDel;
        private HZH_Controls.Controls.UCBtnExt BtnEdit;
        private HZH_Controls.Controls.UCBtnExt BtnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private HZH_Controls.Controls.UCBtnExt BtnSearch;
        private HZH_Controls.Controls.UCBtnExt BtnPrint;
        private HZH_Controls.Controls.UCBtnExt BtnQrCode;
        private HZH_Controls.Controls.UCBtnExt BtnExport;
        private HZH_Controls.Controls.UCBtnExt BtnImport;
    }
}

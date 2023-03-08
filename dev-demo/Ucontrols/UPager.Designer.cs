namespace dev_demo.Ucontrols
{
    partial class UPager
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
            this.PageInfo = new DevExpress.XtraEditors.LabelControl();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnPre = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast = new DevExpress.XtraEditors.SimpleButton();
            this.txtPageNo = new DevExpress.XtraEditors.TextEdit();
            this.btnGoto = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PageInfo
            // 
            this.PageInfo.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.PageInfo.Appearance.Options.UseForeColor = true;
            this.PageInfo.Location = new System.Drawing.Point(14, 13);
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Size = new System.Drawing.Size(98, 14);
            this.PageInfo.TabIndex = 0;
            this.PageInfo.Text = "共4页，当前第2页";
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.Location = new System.Drawing.Point(355, 7);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(38, 23);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "<<";
            // 
            // btnPre
            // 
            this.btnPre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPre.Location = new System.Drawing.Point(409, 7);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(31, 23);
            this.btnPre.TabIndex = 2;
            this.btnPre.Text = "<";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(458, 7);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(33, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.Location = new System.Drawing.Point(499, 6);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(37, 23);
            this.btnLast.TabIndex = 2;
            this.btnLast.Text = ">>";
            // 
            // txtPageNo
            // 
            this.txtPageNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPageNo.Location = new System.Drawing.Point(642, 9);
            this.txtPageNo.Name = "txtPageNo";
            this.txtPageNo.Size = new System.Drawing.Size(100, 20);
            this.txtPageNo.TabIndex = 3;
            // 
            // btnGoto
            // 
            this.btnGoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGoto.Location = new System.Drawing.Point(759, 6);
            this.btnGoto.Name = "btnGoto";
            this.btnGoto.Size = new System.Drawing.Size(75, 23);
            this.btnGoto.TabIndex = 4;
            this.btnGoto.Text = "转到";
            // 
            // UPager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnGoto);
            this.Controls.Add(this.txtPageNo);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.PageInfo);
            this.Name = "UPager";
            this.Size = new System.Drawing.Size(842, 39);
            ((System.ComponentModel.ISupportInitialize)(this.txtPageNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl PageInfo;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnPre;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnLast;
        private DevExpress.XtraEditors.TextEdit txtPageNo;
        private DevExpress.XtraEditors.SimpleButton btnGoto;
    }
}

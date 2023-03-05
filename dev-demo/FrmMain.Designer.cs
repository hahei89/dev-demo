namespace dev_demo
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbLoginInfo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cainiaoMenus = new System.Windows.Forms.MenuStrip();
            this.基础信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.站点信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnStation = new System.Windows.Forms.ToolStripButton();
            this.tbtnShelves = new System.Windows.Forms.ToolStripButton();
            this.tbtnEmployee = new System.Windows.Forms.ToolStripButton();
            this.tbtnExpress = new System.Windows.Forms.ToolStripButton();
            this.tbtnDistribute = new System.Windows.Forms.ToolStripButton();
            this.tbtnSelfPick = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoginTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cainiaoMenus.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.lbLoginInfo);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.pictureBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.RoyalBlue;
            this.panelControl1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.RoyalBlue;
            this.panelControl1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 46);
            this.panelControl1.TabIndex = 0;
            // 
            // lbLoginInfo
            // 
            this.lbLoginInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoginInfo.Appearance.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbLoginInfo.Appearance.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lbLoginInfo.Appearance.Options.UseBackColor = true;
            this.lbLoginInfo.Appearance.Options.UseForeColor = true;
            this.lbLoginInfo.Location = new System.Drawing.Point(663, 19);
            this.lbLoginInfo.Name = "lbLoginInfo";
            this.lbLoginInfo.Size = new System.Drawing.Size(116, 14);
            this.lbLoginInfo.TabIndex = 2;
            this.lbLoginInfo.Text = "admin，欢迎使用系统";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(86, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(192, 31);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "菜鸟驿站管理系统";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dev_demo.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cainiaoMenus
            // 
            this.cainiaoMenus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cainiaoMenus.AutoSize = false;
            this.cainiaoMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(189)))), ((int)(((byte)(240)))));
            this.cainiaoMenus.Dock = System.Windows.Forms.DockStyle.None;
            this.cainiaoMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础信息维护ToolStripMenuItem});
            this.cainiaoMenus.Location = new System.Drawing.Point(0, 46);
            this.cainiaoMenus.Name = "cainiaoMenus";
            this.cainiaoMenus.Size = new System.Drawing.Size(800, 40);
            this.cainiaoMenus.TabIndex = 1;
            this.cainiaoMenus.Text = "menuStrip1";
            // 
            // 基础信息维护ToolStripMenuItem
            // 
            this.基础信息维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.站点信息ToolStripMenuItem});
            this.基础信息维护ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.基础信息维护ToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.基础信息维护ToolStripMenuItem.Name = "基础信息维护ToolStripMenuItem";
            this.基础信息维护ToolStripMenuItem.Size = new System.Drawing.Size(118, 36);
            this.基础信息维护ToolStripMenuItem.Text = "基础信息维护";
            // 
            // 站点信息ToolStripMenuItem
            // 
            this.站点信息ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.站点信息ToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.站点信息ToolStripMenuItem.Name = "站点信息ToolStripMenuItem";
            this.站点信息ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.站点信息ToolStripMenuItem.Text = "站点信息";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnStation,
            this.tbtnShelves,
            this.tbtnEmployee,
            this.tbtnExpress,
            this.tbtnDistribute,
            this.tbtnSelfPick});
            this.toolStrip1.Location = new System.Drawing.Point(0, 86);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 34);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnStation
            // 
            this.tbtnStation.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbtnStation.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tbtnStation.Image = global::dev_demo.Properties.Resources.zhandianguanli;
            this.tbtnStation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnStation.Name = "tbtnStation";
            this.tbtnStation.Size = new System.Drawing.Size(76, 31);
            this.tbtnStation.Text = "站点信息";
            // 
            // tbtnShelves
            // 
            this.tbtnShelves.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbtnShelves.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tbtnShelves.Image = global::dev_demo.Properties.Resources.huojia;
            this.tbtnShelves.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnShelves.Name = "tbtnShelves";
            this.tbtnShelves.Size = new System.Drawing.Size(76, 31);
            this.tbtnShelves.Text = "货架信息";
            // 
            // tbtnEmployee
            // 
            this.tbtnEmployee.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbtnEmployee.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tbtnEmployee.Image = global::dev_demo.Properties.Resources.yuangongguanli_;
            this.tbtnEmployee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnEmployee.Name = "tbtnEmployee";
            this.tbtnEmployee.Size = new System.Drawing.Size(76, 31);
            this.tbtnEmployee.Text = "员工信息";
            // 
            // tbtnExpress
            // 
            this.tbtnExpress.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbtnExpress.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tbtnExpress.Image = global::dev_demo.Properties.Resources.kuaidi;
            this.tbtnExpress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnExpress.Name = "tbtnExpress";
            this.tbtnExpress.Size = new System.Drawing.Size(76, 31);
            this.tbtnExpress.Text = "快递信息";
            // 
            // tbtnDistribute
            // 
            this.tbtnDistribute.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbtnDistribute.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tbtnDistribute.Image = global::dev_demo.Properties.Resources.baoguopaisong;
            this.tbtnDistribute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDistribute.Name = "tbtnDistribute";
            this.tbtnDistribute.Size = new System.Drawing.Size(76, 31);
            this.tbtnDistribute.Text = "派送管理";
            // 
            // tbtnSelfPick
            // 
            this.tbtnSelfPick.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.tbtnSelfPick.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tbtnSelfPick.Image = global::dev_demo.Properties.Resources.zitigui;
            this.tbtnSelfPick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSelfPick.Name = "tbtnSelfPick";
            this.tbtnSelfPick.Size = new System.Drawing.Size(76, 31);
            this.tbtnSelfPick.Text = "快递自提";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblLoginTime,
            this.toolStripStatusLabel3,
            this.lblAction,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel1.Text = "登录时间: ";
            // 
            // lblLoginTime
            // 
            this.lblLoginTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoginTime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(126, 17);
            this.lblLoginTime.Text = "2022-10-25 10:24:30";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel3.Text = "当前操作: ";
            // 
            // lblAction
            // 
            this.lblAction.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(32, 17);
            this.lblAction.Text = "首页";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(408, 17);
            this.toolStripStatusLabel7.Spring = true;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 2);
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel5.Text = "系统版权:";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel6.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabel6.Text = "sss";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 123);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(800, 300);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = global::dev_demo.Properties.Resources.close;
            this.picClose.InitialImage = global::dev_demo.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(776, 1);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(23, 20);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(798, 274);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.cainiaoMenus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.cainiaoMenus;
            this.Name = "FrmMain";
            this.Text = "菜鸟驿站管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cainiaoMenus.ResumeLayout(false);
            this.cainiaoMenus.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lbLoginInfo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MenuStrip cainiaoMenus;
        private System.Windows.Forms.ToolStripMenuItem 基础信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 站点信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnStation;
        private System.Windows.Forms.ToolStripButton tbtnShelves;
        private System.Windows.Forms.ToolStripButton tbtnEmployee;
        private System.Windows.Forms.ToolStripButton tbtnExpress;
        private System.Windows.Forms.ToolStripButton tbtnDistribute;
        private System.Windows.Forms.ToolStripButton tbtnSelfPick;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblAction;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private System.Windows.Forms.PictureBox picClose;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
    }
}
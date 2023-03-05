namespace dev_demo
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.lblErrMsg = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserPwd = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.tablePanel1.Appearance.Options.UseBackColor = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25.84F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.btnLogin);
            this.tablePanel1.Controls.Add(this.txtUserPwd);
            this.tablePanel1.Controls.Add(this.txtUserName);
            this.tablePanel1.Controls.Add(this.lblErrMsg);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Location = new System.Drawing.Point(117, 89);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 27F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(340, 109);
            this.tablePanel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.tablePanel1.SetColumn(this.btnLogin, 1);
            this.tablePanel1.SetColumnSpan(this.btnLogin, 2);
            this.btnLogin.Location = new System.Drawing.Point(119, 55);
            this.btnLogin.Name = "btnLogin";
            this.tablePanel1.SetRow(this.btnLogin, 2);
            this.btnLogin.Size = new System.Drawing.Size(218, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "登录";
            // 
            // lblErrMsg
            // 
            this.lblErrMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErrMsg.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblErrMsg.Appearance.Options.UseForeColor = true;
            this.tablePanel1.SetColumn(this.lblErrMsg, 1);
            this.lblErrMsg.Location = new System.Drawing.Point(119, 88);
            this.lblErrMsg.Name = "lblErrMsg";
            this.tablePanel1.SetRow(this.lblErrMsg, 3);
            this.lblErrMsg.Size = new System.Drawing.Size(64, 14);
            this.lblErrMsg.TabIndex = 3;
            this.lblErrMsg.Text = "请输入账号!";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 0);
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelControl2.Location = new System.Drawing.Point(89, 30);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(24, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "密码";
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 0);
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelControl1.Location = new System.Drawing.Point(89, 3);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(24, 21);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "账号";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(61, 306);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(456, 3);
            this.labelControl3.TabIndex = 1;
            // 
            // txtUserPwd
            // 
            this.tablePanel1.SetColumn(this.txtUserPwd, 1);
            this.txtUserPwd.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtUserPwd.EditValue = "123456";
            this.txtUserPwd.Location = new System.Drawing.Point(119, 30);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.Properties.PasswordChar = '*';
            this.tablePanel1.SetRow(this.txtUserPwd, 1);
            this.txtUserPwd.Size = new System.Drawing.Size(218, 20);
            this.txtUserPwd.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tablePanel1.SetColumn(this.txtUserName, 1);
            this.txtUserName.EditValue = "admin";
            this.txtUserName.Location = new System.Drawing.Point(119, 3);
            this.txtUserName.Name = "txtUserName";
            this.tablePanel1.SetRow(this.txtUserName, 0);
            this.txtUserName.Size = new System.Drawing.Size(218, 20);
            this.txtUserName.TabIndex = 4;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::dev_demo.Properties.Resources.loginPic;
            this.pictureEdit1.Location = new System.Drawing.Point(117, 15);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(334, 71);
            this.pictureEdit1.TabIndex = 0;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(560, 391);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.pictureEdit1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "菜鸟驿站管理系统登录";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.TextEdit txtUserPwd;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl lblErrMsg;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}


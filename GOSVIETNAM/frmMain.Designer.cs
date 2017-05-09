namespace GOSVietnam
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnAntiban = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGOS = new System.Windows.Forms.Button();
            this.linkFB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkDelete = new System.Windows.Forms.LinkLabel();
            this.linkFixLogin = new System.Windows.Forms.LinkLabel();
            this.linkHD = new System.Windows.Forms.LinkLabel();
            this.linkPMHT = new System.Windows.Forms.LinkLabel();
            this.linkGOSdb = new System.Windows.Forms.LinkLabel();
            this.linkFS = new System.Windows.Forms.LinkLabel();
            this.linkHide = new System.Windows.Forms.LinkLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAntiban
            // 
            this.btnAntiban.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAntiban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAntiban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntiban.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAntiban.Location = new System.Drawing.Point(23, 106);
            this.btnAntiban.Name = "btnAntiban";
            this.btnAntiban.Size = new System.Drawing.Size(101, 45);
            this.btnAntiban.TabIndex = 1;
            this.btnAntiban.Text = "Chạy Antiban";
            this.btnAntiban.UseVisualStyleBackColor = false;
            this.btnAntiban.Click += new System.EventHandler(this.btnAntiban_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "GOS Vietnam";
            // 
            // btnGOS
            // 
            this.btnGOS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGOS.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGOS.Location = new System.Drawing.Point(130, 106);
            this.btnGOS.Name = "btnGOS";
            this.btnGOS.Size = new System.Drawing.Size(101, 45);
            this.btnGOS.TabIndex = 2;
            this.btnGOS.Text = "Chạy GOS";
            this.btnGOS.UseVisualStyleBackColor = false;
            this.btnGOS.Click += new System.EventHandler(this.btnGOS_Click);
            // 
            // linkFB
            // 
            this.linkFB.AutoSize = true;
            this.linkFB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkFB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.linkFB.Location = new System.Drawing.Point(37, 76);
            this.linkFB.Name = "linkFB";
            this.linkFB.Size = new System.Drawing.Size(181, 13);
            this.linkFB.TabIndex = 3;
            this.linkFB.Text = "http://facebook.com/GOSVietnam";
            this.linkFB.Click += new System.EventHandler(this.linkFB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkDelete);
            this.groupBox1.Controls.Add(this.linkFixLogin);
            this.groupBox1.Controls.Add(this.linkHD);
            this.groupBox1.Controls.Add(this.linkPMHT);
            this.groupBox1.Controls.Add(this.linkGOSdb);
            this.groupBox1.Controls.Add(this.linkFS);
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // linkDelete
            // 
            this.linkDelete.AutoSize = true;
            this.linkDelete.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkDelete.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkDelete.Location = new System.Drawing.Point(78, 139);
            this.linkDelete.Name = "linkDelete";
            this.linkDelete.Size = new System.Drawing.Size(75, 17);
            this.linkDelete.TabIndex = 10;
            this.linkDelete.TabStop = true;
            this.linkDelete.Text = "Xóa dữ liệu";
            this.linkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDelete_LinkClicked);
            // 
            // linkFixLogin
            // 
            this.linkFixLogin.AutoSize = true;
            this.linkFixLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkFixLogin.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkFixLogin.Location = new System.Drawing.Point(58, 122);
            this.linkFixLogin.Name = "linkFixLogin";
            this.linkFixLogin.Size = new System.Drawing.Size(115, 17);
            this.linkFixLogin.TabIndex = 9;
            this.linkFixLogin.TabStop = true;
            this.linkFixLogin.Text = "Sửa lỗi đăng nhập";
            this.linkFixLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFixLogin_LinkClicked);
            // 
            // linkHD
            // 
            this.linkHD.AutoSize = true;
            this.linkHD.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkHD.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkHD.Location = new System.Drawing.Point(59, 89);
            this.linkHD.Name = "linkHD";
            this.linkHD.Size = new System.Drawing.Size(113, 17);
            this.linkHD.TabIndex = 8;
            this.linkHD.TabStop = true;
            this.linkHD.Text = "Hướng dẫn chung";
            this.linkHD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHD_LinkClicked);
            // 
            // linkPMHT
            // 
            this.linkPMHT.AutoSize = true;
            this.linkPMHT.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkPMHT.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkPMHT.Location = new System.Drawing.Point(38, 72);
            this.linkPMHT.Name = "linkPMHT";
            this.linkPMHT.Size = new System.Drawing.Size(155, 17);
            this.linkPMHT.TabIndex = 7;
            this.linkPMHT.TabStop = true;
            this.linkPMHT.Text = "Cài đặt phần mềm hỗ trợ";
            this.linkPMHT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPMHT_LinkClicked);
            // 
            // linkGOSdb
            // 
            this.linkGOSdb.AutoSize = true;
            this.linkGOSdb.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkGOSdb.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkGOSdb.Location = new System.Drawing.Point(61, 39);
            this.linkGOSdb.Name = "linkGOSdb";
            this.linkGOSdb.Size = new System.Drawing.Size(109, 17);
            this.linkGOSdb.TabIndex = 6;
            this.linkGOSdb.TabStop = true;
            this.linkGOSdb.Text = "Tải Scripts Online";
            this.linkGOSdb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGOSdb_LinkClicked);
            // 
            // linkFS
            // 
            this.linkFS.AutoSize = true;
            this.linkFS.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkFS.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkFS.Location = new System.Drawing.Point(58, 22);
            this.linkFS.Name = "linkFS";
            this.linkFS.Size = new System.Drawing.Size(115, 17);
            this.linkFS.TabIndex = 5;
            this.linkFS.TabStop = true;
            this.linkFS.Text = "Cài đặt Full Scripts";
            this.linkFS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFS_LinkClicked);
            // 
            // linkHide
            // 
            this.linkHide.AutoSize = true;
            this.linkHide.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkHide.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkHide.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkHide.Location = new System.Drawing.Point(186, 346);
            this.linkHide.Name = "linkHide";
            this.linkHide.Size = new System.Drawing.Size(57, 13);
            this.linkHide.TabIndex = 5;
            this.linkHide.TabStop = true;
            this.linkHide.Text = "Ẩn xuống";
            this.linkHide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHide_LinkClicked);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowWebBrowserDrop = false;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(15, 341);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(153, 20);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Url = new System.Uri("http://azir.wapka.me", System.UriKind.Absolute);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(255, 368);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.linkHide);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkFB);
            this.Controls.Add(this.btnGOS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAntiban);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GOS Vietnam";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAntiban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGOS;
        private System.Windows.Forms.Label linkFB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkFS;
        private System.Windows.Forms.LinkLabel linkDelete;
        private System.Windows.Forms.LinkLabel linkFixLogin;
        private System.Windows.Forms.LinkLabel linkHD;
        private System.Windows.Forms.LinkLabel linkPMHT;
        private System.Windows.Forms.LinkLabel linkGOSdb;
        private System.Windows.Forms.LinkLabel linkHide;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}


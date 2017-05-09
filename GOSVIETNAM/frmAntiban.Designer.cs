namespace GOSVietnam
{
    partial class frmAntiban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAntiban));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btnHide = new DevComponents.DotNetBar.ButtonX();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnBlock = new DevComponents.DotNetBar.ButtonX();
            this.btnTiepTuc = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))));
            // 
            // btnHide
            // 
            this.btnHide.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHide.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHide.Location = new System.Drawing.Point(139, 110);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(72, 23);
            this.btnHide.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHide.TabIndex = 0;
            this.btnHide.Text = "Ẩn xuống";
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "GOS Vietnam Antiban by dNG";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnBlock
            // 
            this.btnBlock.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBlock.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBlock.Location = new System.Drawing.Point(60, 26);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(105, 23);
            this.btnBlock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBlock.TabIndex = 2;
            this.btnBlock.Text = "Bật antiban";
            this.btnBlock.Click += new System.EventHandler(this.btnBypass_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTiepTuc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTiepTuc.Location = new System.Drawing.Point(60, 55);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(105, 23);
            this.btnTiepTuc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTiepTuc.TabIndex = 3;
            this.btnTiepTuc.Text = "Tắt antiban";
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Location = new System.Drawing.Point(12, 110);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 23);
            this.btnThoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát (an toàn)";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMainMetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 133);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnHide);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainMetro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GOS Vietnam Antiban";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMetro_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMetro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX btnHide;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private DevComponents.DotNetBar.ButtonX btnBlock;
        private DevComponents.DotNetBar.ButtonX btnTiepTuc;
        private DevComponents.DotNetBar.ButtonX btnThoat;
    }
}
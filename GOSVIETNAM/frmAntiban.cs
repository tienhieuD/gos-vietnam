using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace GOSVietnam
{
    public partial class frmAntiban : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmAntiban()
        {
            InitializeComponent();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon1.Visible = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon1.Visible = false;
        }

        private void frmMainMetro_Load(object sender, EventArgs e)
        {
            btnTiepTuc.Enabled = false;
        }

        private void btnBypass_Click(object sender, EventArgs e)
        {
            btnTiepTuc.Enabled = true;
            btnBlock.Enabled = false;
            Method.SuspendProcess("ggdllhost");
            Method.SuspendProcess("GarenaMessenger");
            Method.KillProcess("BBTalk");
        }

        private void frmMainMetro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Method.KillProcess("ggdllhost");
            Method.KillProcess("GarenaMessenger");
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            btnTiepTuc.Enabled = false;
            btnBlock.Enabled = true;
            Method.ResumeProcess("ggdllhost");
            Method.ResumeProcess("GarenaMessenger");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
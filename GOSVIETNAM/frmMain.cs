using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace GOSVietnam
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void run(string fileName)
        {
            try
            {
                Process.Start("C:\\GOS Vietnam\\" + fileName);
            }
            catch
            {
                MessageBox.Show("Không thể khởi động, thiếu file " + fileName + "?\nTắt Antivirus (nếu có) và thử cài lại.\nInbox fanpage để được trợ giúp!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void link(string linkName)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đi tới liên kết \"" + linkName + "\" không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes) System.Diagnostics.Process.Start(linkName);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void linkHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void linkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tùy chọn này sẽ xóa tất cả dữ liệu GOS của bạn AppData\\Roaming\\GamingOnSteroids \nDùng cho trường hợp GOS bị lỗi.\nBạn có muốn tiếp tục?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GamingOnSteroids");

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    System.IO.DirectoryInfo di = new DirectoryInfo(fileName);
                    foreach (FileInfo file in di.GetFiles()) file.Delete();
                    foreach (DirectoryInfo dir in di.GetDirectories()) dir.Delete(true);
                    Directory.Delete(fileName);

                    MessageBox.Show("Đã xóa\n" + fileName, "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                catch
                {
                    MessageBox.Show("Lỗi, không thể tìm thấy hoặc đã xóa trước đó\n" + fileName, "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void btnAntiban_Click(object sender, EventArgs e)
        {
            run("GOSVNUniKeyNT.exe");
        }

        private void btnGOS_Click(object sender, EventArgs e)
        {
            run("GOSVNUniKey.exe");
            //run file
        }

        private void linkFS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            run("GOSVNData.exe");
            frmFullScript frmFS = new frmFullScript();
            frmFS.Show();
        }

        private void linkFixLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            run("GOSVNLogin.exe");
            MessageBox.Show("Vui lòng tắt GOS và chạy lại!","  Xong!");
        }

        private void linkGOSdb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link("http://gos-db.com");
        }

        private void linkPMHT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link("http://gosvietnam.wapka.mobi/site_phanmemhotro.xhtml");
        }

        private void linkHD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            link("http://gosvietnam.wapka.mobi/site_huongdan.xhtml");
        }

        private void linkFB_Click(object sender, EventArgs e)
        {
            link("http://fb.co/gosvietnam");
        }
        

       
    }
}

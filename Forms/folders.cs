using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_Arena_Checker_ver._2
{
    public partial class folders : Form
    {
        public folders()
        {
            InitializeComponent();
            LocalCheck.Visible = false;
            RoamingCheck.Visible = false;
            PrefetchCheck.Visible = false;
            RecentCheck.Visible = false;
            DocumentsCheck.Visible = false;
            DownloadsCheck.Visible = false;
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Users\" + Environment.UserName + @"\AppData\Local");
            LocalCheck.Visible = true;
        }

        private void btnRoaming_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Users\" + Environment.UserName + @"\AppData\Roaming");
            RoamingCheck.Visible = true;
        }

        private void btnPrefetch_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Windows\prefetch");
            PrefetchCheck.Visible = true;
        }

        private void btnRecent_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Microsoft\Windows\Recent");
            RecentCheck.Visible = true;
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Users\" + Environment.UserName + @"\Documents");
            DocumentsCheck.Visible = true;
        }

        private void btnDownloads_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\Users\" + Environment.UserName + @"\Downloads");
            DownloadsCheck.Visible = true;
        }

        private void btnAllFolders_Click(object sender, EventArgs e)
        {
            string[] folderPaths = {
                @"C:\Users\" + Environment.UserName + @"\AppData\Local",
                @"C:\Users\" + Environment.UserName + @"\AppData\Roaming",
                @"C:\Windows\prefetch",
                @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\Microsoft\Windows\Recent",
                @"C:\Users\" + Environment.UserName + @"\Documents",
                @"C:\Users\" + Environment.UserName + @"\Downloads"
                };

            foreach (string folderPath in folderPaths)
            {
                Process.Start("explorer.exe", folderPath);
            }

            LocalCheck.Visible = true;
            RoamingCheck.Visible = true;
            PrefetchCheck.Visible = true;
            RecentCheck.Visible = true;
            DocumentsCheck.Visible = true;
            DownloadsCheck.Visible = true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_Arena_Checker_ver._2.Forms
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(234, 141, 247);
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(234, 141, 247);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://proarena-cs.ru/donate/");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MAX1MDEV");
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discordapp.com/users/390102465586003978");
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kwork.ru/user/maximdev");
        }
    }
}

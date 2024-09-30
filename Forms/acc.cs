using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static Pro_Arena_Checker_ver._2.Forms.tools;

namespace Pro_Arena_Checker_ver._2.Forms
{
    public partial class acc : Form
    {
        public acc()
        {
            InitializeComponent();
        }
        private void acc_Load(object sender, EventArgs e)
        {
            Process.Start(@"C:/Program Files/Pro-Arena Checker/Account Check.bat");
            Thread.Sleep(2000);
            string filePath = @"C:/Program Files/Pro-Arena Checker/acc.txt";
            List<string> accountNameLines = new List<string>();
            List<string> personaNameLines = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("AccountName"))
                    {
                        accountNameLines.Add(line);
                    }
                    else if (line.Contains("PersonaName"))
                    {
                        personaNameLines.Add(line);
                    }
                }
            }
            dataGridView1.Columns.Add("AccountName", "Account Name");
            dataGridView1.Columns.Add("PersonaName", "Persona Name");
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BackColor = Color.FromArgb(234, 141, 247);
            dataGridView1.Columns[0].HeaderText = "Имя аккаунта";
            dataGridView1.Columns[1].HeaderText = "Ник игрока";
            dataGridView1.Columns[0].Width = 707;
            dataGridView1.Columns[1].Width = 173;
            for (int i = 0; i < Math.Max(accountNameLines.Count, personaNameLines.Count); i++)
            {
                string accountName = i < accountNameLines.Count ? accountNameLines[i].Replace("\"", "").Replace("AccountName", "") : "";
                string personaName = i < personaNameLines.Count ? personaNameLines[i].Replace("\"", "").Replace("PersonaName", "") : "";


                dataGridView1.Rows.Add(accountName, personaName);
            }
        }
    }
}

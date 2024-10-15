using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            int numBrowsers = int.Parse(txtNumBrowsers.Text.ToString());
            string url = txtUrl.Text;

            for (int i = 0; i < numBrowsers; i++)
            {
                Process.Start("chrome.exe", url);
            }
        }


        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("chrome"))
            {
                process.Kill();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

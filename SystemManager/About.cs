using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CSharpFinalProject
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void GHLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/Quriosity0/SystemManager",
                UseShellExecute = true
            });
        }
    }
}

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CSharpFinalProject
{
    public partial class sysman : Form
    {
        public sysman()
        {
            InitializeComponent();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "shell:::{2559a1f3-21d7-11d4-bdaf-00c04f60b9f0}");
        }
    }
}

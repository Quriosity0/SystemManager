using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CSharpFinalProject
{
    public partial class ProcKill : Form
    {
        string procName;
        SysMan obj = new SysMan();

        public ProcKill()
        {
            InitializeComponent();
        }

        private void ProcKill_Load(object sender, EventArgs e)
        {
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            procName = ProcName.Text;

            Process[] processes = Process.GetProcessesByName(procName);

            foreach (Process p in processes)
            {
                p.Kill();
                p.WaitForExit();
            }
            obj.UpdateList();
            Close();
        }
    }
}

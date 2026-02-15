using System;
using System.Windows.Forms;
using System.Diagnostics;

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

            // Terminate all processes with the specified name,
            // wait for each process to exit, update the process list, and close the form
            foreach (Process p in processes)
            {
                try
                {
                    p.Kill();
                    p.WaitForExit();
                }
                // Some system processes may throw Access Denied or have exited 
                catch (Exception ex)
                {
                    using (StreamWriter writer = new StreamWriter("log.txt", true))
                    {
                        writer.WriteLine($"[{DateTime.Now}] Program threw an exception: {ex} (Access Denied or process already exited)");
                    }
                }
                obj.UpdateList();
                Close();
            }
        }
    }
}
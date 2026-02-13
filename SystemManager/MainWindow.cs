using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SystemManager;

namespace CSharpFinalProject
{
    public partial class SysMan : Form
    {
        Dictionary<int, ListViewItem> ProcessList = new Dictionary<int, ListViewItem>();
        public SysMan()
        {
            InitializeComponent();
        }
        private void UpdateList()
        {
            Process[] processes = Process.GetProcesses();
            HashSet<int> ActiveProcesses = new HashSet<int>();

            foreach (Process p in processes)
            {
                try
                {
                    ActiveProcesses.Add(p.Id);

                    if (ProcessList.TryGetValue(p.Id, out var item))
                    {
                        item.SubItems[3].Text = $"{p.WorkingSet64 / 1024 / 1024} MB";
                        item.SubItems[4].Text = p.Threads.Count.ToString();
                    }
                    else
                    {
                        var process = new ListViewItem(p.ProcessName);
                        process.SubItems.Add(p.Id.ToString());
                        process.SubItems.Add($"");
                        process.SubItems.Add($"{p.WorkingSet64 / 1024 / 1024} MB");
                        process.SubItems.Add(p.Threads.Count.ToString());
                        process.Tag = p.Id;

                        ProcessList[p.Id] = process;
                        ProcList.Items.Add(process);
                    }
                }
                catch { }
            }

            foreach (var pid in ProcessList.Keys.ToList())
            {
                if (!ActiveProcesses.Contains(pid))
                {
                    ProcList.Items.Remove(ProcessList[pid]);
                    ProcessList.Remove(pid);
                }
            }

            ProcList.EndUpdate();
        }
        private void KillSelectedProcess()
        {
            if (ProcList.SelectedItems.Count == 0) return;

            int pid = (int)ProcList.SelectedItems[0].Tag;
            Process.GetProcessById(pid).Kill();

            UpdateList();
        }
        private async void MeasureSystemLoad()
        {
            var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            cpuCounter.NextValue();
            await Task.Delay(500);

            while (true)
            {
                float cpuUsage = cpuCounter.NextValue();
                cpuLabel.Text = $"CPU: {cpuUsage:F1}%";
                await Task.Delay(1000);
            }
        }
        private void sysman_Load(object sender, EventArgs e)
        {
            UpdateTimer.Interval = 1000;
            UpdateTimer.Tick += (s, e) =>
            {
                UpdateList();
            };
            MeasureSystemLoad();
            UpdateTimer.Start();
        }


        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "shell:::{2559a1f3-21d7-11d4-bdaf-00c04f60b9f0}");
        }
        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcKill window = new ProcKill();
            window.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About window = new About();
            window.Show();
        }

        private void killBtn_Click(object sender, EventArgs e)
        {
            KillSelectedProcess();
        }
        private void killProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KillSelectedProcess();
        }
        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropsWindow window = new PropsWindow { };
            window.Show();
        }
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
        }
    }
}
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SystemManager;

namespace CSharpFinalProject
{
    // Main window of the application, showing the list of processes and system load
    public partial class SysMan : Form
    {
        // Dictionary to keep track of ListViewItems for each process ID
        Dictionary<int, ListViewItem> ProcessList = new Dictionary<int, ListViewItem>();
        public SysMan()
        {
            InitializeComponent();
        }

        // Updates the process list by comparing currently running processes with the existing list and adding/removing items accordingly
        public void UpdateList()
        {
            ProcList.BeginUpdate();
            // Getting list of currently running processes
            Process[] processes = Process.GetProcesses();
            // HashSet is faster for lookups than a List, so I use it to track active PIDs
            HashSet<int> ActiveProcesses = new HashSet<int>();

            foreach (Process p in processes)
            {
                try
                {
                    ActiveProcesses.Add(p.Id);

                    // If the process is already in the list, update it instead of creating a new item
                    if (ProcessList.TryGetValue(p.Id, out var item))
                    {
                        item.SubItems[3].Text = $"{p.WorkingSet64 / 1024 / 1024} MB";
                        item.SubItems[4].Text = p.Threads.Count.ToString();
                    }
                    // If process is new, create new item and add it to the ListView and dictionary
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
                catch (Exception ex) 
                {
                    using (StreamWriter writer = new StreamWriter("log.txt", true))
                    {
                        writer.WriteLine($"[{DateTime.Now}] Program threw an exception: {ex}");
                    }
                }
            }
            // Remove processes that are no longer running from the ListView and dictionary
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

            try {
                // Get the PID of the selected in ListView process and kill it
                int pid = (int)ProcList.SelectedItems[0].Tag;
                Process.GetProcessById(pid).Kill();
            }
            catch (Exception) {
                // Some system processes may throw Access Denied or have exited
                using (StreamWriter writer = new StreamWriter("log.txt", true))
                {
                    writer.WriteLine($"[{DateTime.Now}] Program threw an exception (Access Denied or process already exited)");
                }
            }

            UpdateList();
        }
        // Asynchronously measures CPU usage using PerformanceCounter and updates the label every second
        private async void MeasureSystemLoad()
        {
            var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            // The first call to NextValue() always returns 0, so we call it once and wait before starting the loop
            cpuCounter.NextValue();
            await Task.Delay(500);

            while (true)
            {
                float cpuUsage = cpuCounter.NextValue();
                cpuLabel.Text = $"CPU: {cpuUsage:F1}%";
                await Task.Delay(1000);
            }
        }
        // Opens the file location of the selected process in Windows Explorer
        private void OpenFileLocation()
        {
            if (ProcList.SelectedItems.Count == 0) return;

            try
            {
                // Get the PID of the selected in ListView process
                int pid = (int)ProcList.SelectedItems[0].Tag;

                Process pr = Process.GetProcessById(pid);
                string path = pr.MainModule.FileName;
                Process.Start("explorer.exe", $"/select,\"{path}\"");
            }
            catch (Exception ex) 
            {
                using (StreamWriter writer = new StreamWriter("log.txt", true))
                {
                    writer.WriteLine($"[{DateTime.Now}] Program threw an exception: {ex}");
                }
            }
        }
        private void sysman_Load(object sender, EventArgs e)
        {
            // Set up a timer to update the process list every second
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
            // Open the Run dialog using the shell command
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
        private void openFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileLocation();
        }
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
        }
    }
}
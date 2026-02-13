namespace CSharpFinalProject
{
    partial class SysMan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysMan));
            contextMenu = new ContextMenuStrip(components);
            killProcessToolStripMenuItem = new ToolStripMenuItem();
            TopMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            runToolStripMenuItem = new ToolStripMenuItem();
            killToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            killBtn = new Button();
            ProcList = new ListView();
            ProcName = new ColumnHeader();
            PID = new ColumnHeader();
            CPU = new ColumnHeader();
            Mem = new ColumnHeader();
            Threads = new ColumnHeader();
            cpuLabel = new Label();
            UpdateTimer = new System.Windows.Forms.Timer(components);
            contextMenu.SuspendLayout();
            TopMenu.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenu
            // 
            contextMenu.Items.AddRange(new ToolStripItem[] { killProcessToolStripMenuItem });
            contextMenu.Name = "contextMenuStrip1";
            contextMenu.Size = new Size(181, 48);
            // 
            // killProcessToolStripMenuItem
            // 
            killProcessToolStripMenuItem.Name = "killProcessToolStripMenuItem";
            killProcessToolStripMenuItem.Size = new Size(180, 22);
            killProcessToolStripMenuItem.Text = "Kill process";
            killProcessToolStripMenuItem.Click += killProcessToolStripMenuItem_Click;
            // 
            // TopMenu
            // 
            TopMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            TopMenu.Location = new Point(0, 0);
            TopMenu.Name = "TopMenu";
            TopMenu.Size = new Size(652, 24);
            TopMenu.TabIndex = 1;
            TopMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { runToolStripMenuItem, killToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(95, 22);
            runToolStripMenuItem.Text = "Run";
            runToolStripMenuItem.Click += runToolStripMenuItem_Click;
            // 
            // killToolStripMenuItem
            // 
            killToolStripMenuItem.Name = "killToolStripMenuItem";
            killToolStripMenuItem.Size = new Size(95, 22);
            killToolStripMenuItem.Text = "Kill";
            killToolStripMenuItem.Click += killToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(95, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // killBtn
            // 
            killBtn.Location = new Point(569, 498);
            killBtn.Name = "killBtn";
            killBtn.Size = new Size(75, 23);
            killBtn.TabIndex = 2;
            killBtn.Text = "Kill process";
            killBtn.UseVisualStyleBackColor = true;
            killBtn.Click += killBtn_Click;
            // 
            // ProcList
            // 
            ProcList.Columns.AddRange(new ColumnHeader[] { ProcName, PID, CPU, Mem, Threads });
            ProcList.FullRowSelect = true;
            ProcList.GridLines = true;
            ProcList.Location = new Point(0, 27);
            ProcList.Name = "ProcList";
            ProcList.Size = new Size(652, 465);
            ProcList.TabIndex = 3;
            ProcList.UseCompatibleStateImageBehavior = false;
            ProcList.View = View.Details;
            // 
            // ProcName
            // 
            ProcName.Text = "Name";
            ProcName.Width = 200;
            // 
            // PID
            // 
            PID.Text = "PID";
            PID.Width = 70;
            // 
            // CPU
            // 
            CPU.Text = "CPU (%)";
            // 
            // Mem
            // 
            Mem.Text = "Memory";
            Mem.Width = 100;
            // 
            // Threads
            // 
            Threads.Text = "Threads";
            // 
            // cpuLabel
            // 
            cpuLabel.AutoSize = true;
            cpuLabel.Location = new Point(12, 506);
            cpuLabel.Name = "cpuLabel";
            cpuLabel.Size = new Size(61, 15);
            cpuLabel.TabIndex = 4;
            cpuLabel.Text = "CPU: 0.0%";
            // 
            // SysMan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 529);
            Controls.Add(cpuLabel);
            Controls.Add(ProcList);
            Controls.Add(killBtn);
            Controls.Add(TopMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = TopMenu;
            Name = "SysMan";
            Text = "System Manager";
            Load += sysman_Load;
            contextMenu.ResumeLayout(false);
            TopMenu.ResumeLayout(false);
            TopMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenu;
        private MenuStrip TopMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem killToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem killProcessToolStripMenuItem;
        private Button killBtn;
        private ListView ProcList;
        private ColumnHeader ProcName;
        private ColumnHeader PID;
        private ColumnHeader Mem;
        private ColumnHeader Threads;
        private Label cpuLabel;
        private System.Windows.Forms.Timer UpdateTimer;
        private ColumnHeader CPU;
    }
}

namespace CSharpFinalProject
{
    partial class sysman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sysman));
            contextMenuStrip1 = new ContextMenuStrip(components);
            killProcessToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
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
            Mem = new ColumnHeader();
            Threads = new ColumnHeader();
            cpuLabel = new Label();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { killProcessToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(134, 26);
            // 
            // killProcessToolStripMenuItem
            // 
            killProcessToolStripMenuItem.Name = "killProcessToolStripMenuItem";
            killProcessToolStripMenuItem.Size = new Size(133, 22);
            killProcessToolStripMenuItem.Text = "Kill process";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(652, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
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
            ProcList.Columns.AddRange(new ColumnHeader[] { ProcName, PID, Mem, Threads });
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
            ProcName.Width = 250;
            // 
            // PID
            // 
            PID.Text = "PID";
            PID.Width = 70;
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
            // sysman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 529);
            Controls.Add(cpuLabel);
            Controls.Add(ProcList);
            Controls.Add(killBtn);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "sysman";
            Text = "System Manager";
            Load += sysman_Load;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
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
    }
}

namespace CSharpFinalProject
{
    partial class ProcKill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcKill));
            label1 = new Label();
            CancelBtn = new Button();
            ProcName = new TextBox();
            label2 = new Label();
            OKBtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(65, 19);
            label1.Name = "label1";
            label1.Size = new Size(302, 50);
            label1.TabIndex = 0;
            label1.Text = "Type the name of a process or program, and System Monitor will kill it for you";
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(292, 131);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 1;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // ProcName
            // 
            ProcName.Location = new Point(56, 72);
            ProcName.Name = "ProcName";
            ProcName.Size = new Size(311, 23);
            ProcName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 4;
            label2.Text = "Kill:";
            // 
            // OKBtn
            // 
            OKBtn.Location = new Point(211, 131);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(75, 23);
            OKBtn.TabIndex = 5;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = true;
            OKBtn.Click += OKBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = SystemManager.Properties.Resources.prockill;
            pictureBox1.Location = new Point(-1, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ProcKill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 166);
            Controls.Add(pictureBox1);
            Controls.Add(OKBtn);
            Controls.Add(label2);
            Controls.Add(ProcName);
            Controls.Add(CancelBtn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProcKill";
            Text = "Kill";
            Load += ProcKill_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CancelBtn;
        private TextBox ProcName;
        private Label label2;
        private Button OKBtn;
        private PictureBox pictureBox1;
    }
}
namespace CLI
{
    partial class SSHCLI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cliConsole1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cliConsole2 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cliConsole3 = new System.Windows.Forms.Panel();
            this.cmdBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 349);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cliConsole1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CLI 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cliConsole1
            // 
            this.cliConsole1.BackColor = System.Drawing.Color.Black;
            this.cliConsole1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cliConsole1.Location = new System.Drawing.Point(3, 3);
            this.cliConsole1.Name = "cliConsole1";
            this.cliConsole1.Size = new System.Drawing.Size(632, 317);
            this.cliConsole1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cliConsole2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CLI 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cliConsole2
            // 
            this.cliConsole2.BackColor = System.Drawing.Color.Black;
            this.cliConsole2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cliConsole2.Location = new System.Drawing.Point(3, 3);
            this.cliConsole2.Name = "cliConsole2";
            this.cliConsole2.Size = new System.Drawing.Size(632, 317);
            this.cliConsole2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cliConsole3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(638, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CLI 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cliConsole3
            // 
            this.cliConsole3.BackColor = System.Drawing.Color.Black;
            this.cliConsole3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cliConsole3.Location = new System.Drawing.Point(3, 3);
            this.cliConsole3.Name = "cliConsole3";
            this.cliConsole3.Size = new System.Drawing.Size(632, 317);
            this.cliConsole3.TabIndex = 1;
            // 
            // cmdBox
            // 
            this.cmdBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdBox.FormattingEnabled = true;
            this.cmdBox.Location = new System.Drawing.Point(337, 16);
            this.cmdBox.Name = "cmdBox";
            this.cmdBox.Size = new System.Drawing.Size(306, 21);
            this.cmdBox.TabIndex = 17;
            this.cmdBox.TabStop = false;
            this.cmdBox.SelectedIndexChanged += new System.EventHandler(this.cmdBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(211, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "SELECT COMMAND :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 39);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Copied to clipboard, right click to paste.";
            this.label2.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.statusBox);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(646, 44);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " Status";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(3, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "RESET CONNECTION";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.Color.Red;
            this.statusBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.statusBox.Location = new System.Drawing.Point(606, 16);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(25, 25);
            this.statusBox.TabIndex = 0;
            this.statusBox.TabStop = false;
            // 
            // SSHCLI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox5);
            this.MinimumSize = new System.Drawing.Size(354, 471);
            this.Name = "SSHCLI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CLI ";
            this.Load += new System.EventHandler(this.cliForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabControl tabControl1;
        internal System.Windows.Forms.ComboBox cmdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.PictureBox statusBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel cliConsole1;
        public System.Windows.Forms.Panel cliConsole2;
        public System.Windows.Forms.Panel cliConsole3;
        public System.Windows.Forms.Button button1;
    }
}
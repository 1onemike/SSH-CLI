namespace CLI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCLINew = new System.Windows.Forms.ToolStripMenuItem();
            this.lOADSESSIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVESESSIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITCOMMANDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oEFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBox = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCLI = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.eDITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCLINew,
            this.lOADSESSIONToolStripMenuItem,
            this.sAVESESSIONToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // menuCLINew
            // 
            this.menuCLINew.Enabled = false;
            this.menuCLINew.Name = "menuCLINew";
            this.menuCLINew.Size = new System.Drawing.Size(153, 22);
            this.menuCLINew.Text = "NEW CLI";
            this.menuCLINew.Click += new System.EventHandler(this.menuCLINew_Click);
            // 
            // lOADSESSIONToolStripMenuItem
            // 
            this.lOADSESSIONToolStripMenuItem.Name = "lOADSESSIONToolStripMenuItem";
            this.lOADSESSIONToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.lOADSESSIONToolStripMenuItem.Text = "LOAD SESSION";
            this.lOADSESSIONToolStripMenuItem.Click += new System.EventHandler(this.lOADSESSIONToolStripMenuItem_Click);
            // 
            // sAVESESSIONToolStripMenuItem
            // 
            this.sAVESESSIONToolStripMenuItem.Name = "sAVESESSIONToolStripMenuItem";
            this.sAVESESSIONToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sAVESESSIONToolStripMenuItem.Text = "SAVE SESSION";
            this.sAVESESSIONToolStripMenuItem.Click += new System.EventHandler(this.sAVESESSIONToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDITCOMMANDSToolStripMenuItem,
            this.oEFormToolStripMenuItem});
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.eDITToolStripMenuItem.Text = "EDIT";
            // 
            // eDITCOMMANDSToolStripMenuItem
            // 
            this.eDITCOMMANDSToolStripMenuItem.Name = "eDITCOMMANDSToolStripMenuItem";
            this.eDITCOMMANDSToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.eDITCOMMANDSToolStripMenuItem.Text = "EDIT COMMANDS";
            this.eDITCOMMANDSToolStripMenuItem.Click += new System.EventHandler(this.eDITCOMMANDSToolStripMenuItem_Click);
            // 
            // oEFormToolStripMenuItem
            // 
            this.oEFormToolStripMenuItem.Name = "oEFormToolStripMenuItem";
            this.oEFormToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.oEFormToolStripMenuItem.Text = "OE Form";
            this.oEFormToolStripMenuItem.Click += new System.EventHandler(this.oEFormToolStripMenuItem_Click);
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.Color.Red;
            this.statusBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.statusBox.Location = new System.Drawing.Point(551, 16);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(18, 20);
            this.statusBox.TabIndex = 0;
            this.statusBox.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.statusBox);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(584, 39);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " Status";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.btnCLI);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(369, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 122);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(188, 35);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCLI
            // 
            this.btnCLI.Enabled = false;
            this.btnCLI.Location = new System.Drawing.Point(6, 49);
            this.btnCLI.Name = "btnCLI";
            this.btnCLI.Size = new System.Drawing.Size(188, 35);
            this.btnCLI.TabIndex = 5;
            this.btnCLI.Text = "CLI";
            this.btnCLI.UseVisualStyleBackColor = true;
            this.btnCLI.Click += new System.EventHandler(this.btnCLI_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.Label1);
            this.groupBox3.Controls.Add(this.Label2);
            this.groupBox3.Controls.Add(this.txtPort);
            this.groupBox3.Controls.Add(this.Label3);
            this.groupBox3.Controls.Add(this.txtPassword);
            this.groupBox3.Controls.Add(this.Label4);
            this.groupBox3.Controls.Add(this.txtUsername);
            this.groupBox3.Controls.Add(this.txtHost);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 122);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(95, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "HOST ADDRESS:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(35, 45);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "USERNAME:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(109, 94);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(226, 20);
            this.txtPort.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(33, 71);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(73, 13);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "PASSWORD:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(109, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(226, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(66, 97);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(40, 13);
            this.Label4.TabIndex = 1;
            this.Label4.Text = "PORT:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(109, 42);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(226, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtHost
            // 
            this.txtHost.AutoCompleteCustomSource.AddRange(new string[] {
            "test.rebex.net"});
            this.txtHost.Location = new System.Drawing.Point(109, 13);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(226, 20);
            this.txtHost.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.groupBox3);
            this.GroupBox1.Controls.Add(this.groupBox2);
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GroupBox1.Location = new System.Drawing.Point(0, 63);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(572, 141);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "SSH Connection";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "CLI CONTROL ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCLINew;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITCOMMANDSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVESESSIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOADSESSIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oEFormToolStripMenuItem;
        private System.Windows.Forms.PictureBox statusBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnConnect;
        internal System.Windows.Forms.Button btnCLI;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtPort;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.TextBox txtHost;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}


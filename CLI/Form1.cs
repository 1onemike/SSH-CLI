using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using System.Threading;

namespace CLI
{
    public partial class Form1 : Form
    {
        private bool formsRestored = false;
        private bool formsRestoredOE = false;


        Screen screen;


        public static Random random = new Random();
        private FormProps FormProperty = new FormProps();


        public Form1()
        {
            InitializeComponent();

        }
    

        public void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtHost.TextLength > 0 && txtPassword.TextLength>0 && txtUsername.TextLength>0 && txtPort.TextLength>0)
            {
                try
                {
                    loadCLIForm();
                    statusBox.BackColor = System.Drawing.Color.LimeGreen;
                    btnCLI.Enabled = true;
                    menuCLINew.Enabled = true;
                    btnConnect.Enabled = false;

                }
                catch (Exception exp)
                {
                    MessageBox.Show("Error : " + exp.Message);
                }
            }
            else 
            {
                MessageBox.Show("Error : Please input all details " );

            }




        }

        private void btnCLI_Click(object sender, EventArgs e)
        {
            try
            {
                loadCLIForm();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error : " + exp.Message);
            }
        
        }

        public void loadCLIForm()
        {
            if (!formsRestored)
            {


                string tempPath = Application.StartupPath + "/temp";
                DirectoryInfo d2 = new DirectoryInfo(tempPath);//Assuming Test is your Folder
                                                               //  FileInfo[] Files2 = d2.GetFiles("*.xml"); //Getting Text files
                if (d2.GetFiles("*.xml").Any()) {
                    if (MessageBox.Show("Do you want to load previous session?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        restoreForms();
                    }
                    else
                    {


                        FileInfo[] Files2 = d2.GetFiles("*.xml"); //Getting Text files

                        foreach (FileInfo file in Files2)
                        {
                            if (File.Exists(file.FullName)) File.Delete(file.FullName);
                        }
                        cli_generator cli = new cli_generator();

                        //cli.AddSSH(txtHost.Text, txtUsername.Text, txtPassword.Text, txtPort.Text);

                        if (cli.AddSSH(txtHost.Text, txtUsername.Text, txtPassword.Text, txtPort.Text))
                        {
                          cli.ShowForm();

                        }







                        formsRestored = true;
                    }


                }
                else
                {
                    cli_generator cli = new cli_generator();
                    if (cli.AddSSH(txtHost.Text, txtUsername.Text, txtPassword.Text, txtPort.Text))
                    {
                        cli.ShowForm();

                    }
                    statusBox.BackColor = System.Drawing.Color.LimeGreen;
                    btnCLI.Enabled = true;
                    menuCLINew.Enabled = true;
                    btnConnect.Enabled = false;
                    formsRestored = true;
                  
                }



            }
            else
            {
                cli_generator cli = new cli_generator();

                if (cli.AddSSH(txtHost.Text, txtUsername.Text, txtPassword.Text, txtPort.Text))
                {
                    cli.ShowForm();

                }
                statusBox.BackColor = System.Drawing.Color.LimeGreen;
                btnCLI.Enabled = true;
                menuCLINew.Enabled = true;
                btnConnect.Enabled = false;
            }

        }

        private void restoreForms()
        {
            string tempPath = Application.StartupPath + "/temp";
            DirectoryInfo d = new DirectoryInfo(tempPath);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.xml"); //Getting Text files
            foreach (FileInfo file in Files)
            {
                using (StreamReader streamReader = new StreamReader(file.FullName, Encoding.UTF8))
                {
                    string props = streamReader.ReadToEnd();
                    FormProps formprop = FormProps.ConvertFromXMLString(props);
                    cli_generator cli = new cli_generator(formprop);

                    if (cli.AddSSH(txtHost.Text, txtUsername.Text, txtPassword.Text, txtPort.Text))
                    {
                        cli.ShowForm();
                    }
                  

                    
                  
                    statusBox.BackColor = System.Drawing.Color.LimeGreen;
                    btnCLI.Enabled = true;
                    menuCLINew.Enabled = true;
                    btnConnect.Enabled = false;

                    Thread.Sleep(500);
                }

            }
            formsRestored = true;

           

            foreach (FileInfo file in Files)
            {
                if (File.Exists(file.FullName)) File.Delete(file.FullName);
            }
        }

        private void restoreOEForms()
        {
            string tempPath2 = Application.StartupPath + "/temp2";
            DirectoryInfo d2 = new DirectoryInfo(tempPath2);//Assuming Test is your Folder


            FileInfo[] Files2 = d2.GetFiles("*.xml"); //Getting Text files
            foreach (FileInfo file in Files2)
            {
                using (StreamReader streamReader = new StreamReader(file.FullName, Encoding.UTF8))
                {
                    string props = streamReader.ReadToEnd();
                    FormProps formprop = FormProps.ConvertFromXMLString(props);
                    oe_gen oe = new oe_gen(formprop);

                    oe.ShowForm();
                }

            }
            formsRestoredOE = true;
            foreach (FileInfo file in Files2)
            {
                if (File.Exists(file.FullName)) File.Delete(file.FullName);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


            saveConnectionWindow();

            Main.Fin();


        }

        public static string RandomString(int length = 8)
        {
            const string chars = "0123456789LMNOPQRSTUVWXYZABCDEFGHIJK";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void saveConnectionWindow()
        {
            var configuration = Application.StartupPath + "/temp3/config.xml";
            if (File.Exists(configuration)) File.Delete(configuration);
            screen = Screen.FromControl(this);

            FormProperty.positionLeft = this.Left;
            FormProperty.positionTop = this.Top;
            FormProperty.Screen = screen.DeviceName;
            FormProperty.Host = txtHost.Text;
            FormProperty.User = txtUsername.Text;
            FormProperty.Pass = txtPassword.Text;
            FormProperty.Port = txtPort.Text;

            if (!File.Exists(configuration))
            {
                using (StreamWriter w = File.AppendText(configuration)) { };
            }
            var xs = new XmlSerializer(FormProperty.GetType());
            var ws = new XmlWriterSettings { Indent = true, NewLineOnAttributes = true, OmitXmlDeclaration = true };

            using (XmlWriter writer = XmlWriter.Create(configuration, ws))
            {
                xs.Serialize(writer, FormProperty);
            }
        }

        private void eDITCOMMANDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Input commands per line !");
            Process.Start("notepad.exe", "commands.txt");
        }

        private void menuCLINew_Click(object sender, EventArgs e)
        {
            loadCLIForm();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sAVESESSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tempPath = Application.StartupPath + "/temp";
            DirectoryInfo d = new DirectoryInfo(tempPath);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.xml"); //Getting Text files
            if (Files.Length > 0)
            {
                if (MessageBox.Show("Do you want to save session?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    foreach (FileInfo file in Files)
                    {
                        if (File.Exists(file.FullName)) File.Delete(file.FullName);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please connect and open new CLI forms first", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lOADSESSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {


           
                if (!formsRestored) restoreForms();
            


        }

        private void oEFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!formsRestoredOE) {
                string tempPath = Application.StartupPath + "/temp2";
                DirectoryInfo d2 = new DirectoryInfo(tempPath);//Assuming Test is your Folder

                if (d2.GetFiles("*.xml").Any())
                {
                    if (MessageBox.Show("Do you want to load previous OE session?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        restoreOEForms();
                    }
                    else
                    {


                        FileInfo[] Files2 = d2.GetFiles("*.xml"); //Getting Text files

                        foreach (FileInfo file in Files2)
                        {
                            if (File.Exists(file.FullName)) File.Delete(file.FullName);
                        }

                        oe_gen oe = new oe_gen();

                        oe.ShowForm();

                        formsRestoredOE = true;
                    }
                }
                else
                {
                    oe_gen oe = new oe_gen();

                    oe.ShowForm();

                    formsRestoredOE = true;
                }




            }
            else
            {
                oe_gen oe = new oe_gen();

                oe.ShowForm();
            }




        }

     

      
    }




    

   

}

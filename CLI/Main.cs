using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Test_Load();
        }

        public static void Test_Load()
        {
            System.IO.Directory.CreateDirectory(Application.StartupPath + "/temp");
            System.IO.Directory.CreateDirectory(Application.StartupPath + "/temp1");
            System.IO.Directory.CreateDirectory(Application.StartupPath + "/temp2");
            System.IO.Directory.CreateDirectory(Application.StartupPath + "/temp3");

            try
            {
                string tempPath = Application.StartupPath + "/temp3";
                DirectoryInfo d = new DirectoryInfo(tempPath);//Assuming Test is your Folder
                FileInfo[] Files = d.GetFiles("*.xml"); //Getting Text files
                foreach (FileInfo file in Files)
                {
                    using (StreamReader streamReader = new StreamReader(file.FullName, Encoding.UTF8))
                    {
                        string props = streamReader.ReadToEnd();
                        FormProps formprop = FormProps.ConvertFromXMLString(props);
                        conn_generator conn = new conn_generator(formprop);

                        conn.ShowForm();
                    }

                }
                if (Files.Length<1)
                {
                    System.ArgumentException argEx = new System.ArgumentException("Index is out of range");
                    throw argEx;
                }
              
            }
            catch (System.ArgumentException e)
            {
                conn_generator conn = new conn_generator();

                conn.ShowForm();

            }



        }

        public static void Fin()
        {

           
            Application.Exit();

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            string tempPath = Application.StartupPath + "/temp";
            DirectoryInfo d = new DirectoryInfo(tempPath);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.xml"); //Getting Text files
            if (Files.Length > 0)
            {
                if (MessageBox.Show("Do you want to save CLI session?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    foreach (FileInfo file in Files)
                    {
                        if (File.Exists(file.FullName)) File.Delete(file.FullName);
                    }
                }
            }

            string tempPath2 = Application.StartupPath + "/temp2";
            DirectoryInfo d2 = new DirectoryInfo(tempPath2);//Assuming Test is your Folder
            FileInfo[] Files2 = d2.GetFiles("*.xml"); //Getting Text files
            if (Files2.Length > 0)
            {
                if (MessageBox.Show("Do you want to save OE session?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    foreach (FileInfo file2 in Files2)
                    {
                        if (File.Exists(file2.FullName)) File.Delete(file2.FullName);
                    }
                }
            }
        }
    }
}

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
    public partial class SSHCLI : Form
    {
        public SSHCLI()
        {
            InitializeComponent();
         
            

        }
       

        private void cliForm_Load(object sender, EventArgs e)
        {
            statusBox.BackColor = System.Drawing.Color.LimeGreen;


            string[] lineOfContents = File.ReadAllLines("commands.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');
                cmdBox.Items.Add(tokens[0]);
            }


        }

        private void cmdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(cmdBox.SelectedItem.ToString());
            label2.Visible = true;
        }

       
    }
}

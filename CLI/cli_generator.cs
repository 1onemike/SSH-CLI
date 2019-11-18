using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CLI
{
    class cli_generator
    {
        //INITIALIZATIONS---------------------------------------------------------------------------------------------------------
        SSHCLI cliForm;
        Screen screen;
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);
        [DllImport("user32.dll")]
        public static extern int DeleteMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        System.Diagnostics.Process pt1;
        System.Diagnostics.Process pt2;
        System.Diagnostics.Process pt3;
        public static Random random = new Random();
        private FormProps FormProperty = new FormProps();
        //-------------------------------------------------------------------------------------------------------------------------
        string host;
        string pass;
        string user;
        string port;


        public cli_generator(FormProps props = null)
        {
            cliForm = new SSHCLI();   
            screen = Screen.FromControl(cliForm);
            if (props != null) {
                RestoreProperties(props);
            }
            else
            {
                FormProperty.ID = RandomString();
                setFormLocation(cliForm);
            }

         

            cliForm.Move += new EventHandler(onSaveProperty);
            cliForm.Resize += new EventHandler(onSaveProperty);
            cliForm.FormClosing += new FormClosingEventHandler(onClosing);


            cliForm.tabControl1.SelectedIndexChanged += new EventHandler(tabChange);


            cliForm.Activated += new EventHandler(tabChange);
            cliForm.button1.Click += new System.EventHandler(this.button1_Click);


            saveProperties();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        

            try
            {
                pt1.Kill();
                pt2.Kill();
                pt3.Kill();

            }
            catch (Exception exp)
            {
                MessageBox.Show("Error : " + exp.Message);
                
            }


            AddSSH(host, user, pass, port);
        }

        private void tabChange(object sender, EventArgs e)
        {
            MoveWindow(pt1.MainWindowHandle, -8, -30, cliForm.cliConsole1.Width + 15, cliForm.cliConsole1.Height + 40, true);
            MoveWindow(pt2.MainWindowHandle, -8, -30, cliForm.cliConsole2.Width + 15, cliForm.cliConsole2.Height + 40, true);
            MoveWindow(pt3.MainWindowHandle, -8, -30, cliForm.cliConsole3.Width + 15, cliForm.cliConsole3.Height + 40, true);
        }

        public bool AddSSH(string hostIN, string userIN, string passIN, string portIN)


        {
            host = hostIN;
            pass = passIN;
            port = portIN;
            user = userIN;


            try
            {
                pt1 = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.FileName = "pt.exe";
                startInfo.Arguments = "-ssh " + user + "@" + host + " " + port + " -pw " + pass + " -X -C";
                startInfo.WindowStyle = ProcessWindowStyle.Minimized;

                pt1.StartInfo = startInfo;

               
                pt1.Start();

                pt1.WaitForInputIdle();

                SetParent(pt1.MainWindowHandle, cliForm.cliConsole1.Handle);

                Utilities.HideMinimizeAndMaximizeButtons(pt1.MainWindowHandle);
                MoveWindow(pt1.MainWindowHandle, -8, -30, cliForm.cliConsole1.Width+15, cliForm.cliConsole1.Height+40, true);
               




                pt2 = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo2 = new System.Diagnostics.ProcessStartInfo();
                startInfo2.FileName = "pt.exe";
                startInfo2.Arguments = "-ssh " + user + "@" + host + " " + port + " -pw " + pass + " -X -C";
                startInfo2.WindowStyle = ProcessWindowStyle.Minimized;


                pt2.StartInfo = startInfo2;
                
              //  pt2.StartInfo.CreateNoWindow = true;
               // pt2.StartInfo.UseShellExecute = false;
                pt2.Start();

                pt2.WaitForInputIdle();

                SetParent(pt2.MainWindowHandle, cliForm.cliConsole2.Handle);

                Utilities.HideMinimizeAndMaximizeButtons(pt2.MainWindowHandle);
                MoveWindow(pt2.MainWindowHandle, -8, -30, cliForm.cliConsole2.Width+15, cliForm.cliConsole2.Height+40, true);




                pt3 = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo3 = new System.Diagnostics.ProcessStartInfo();
                startInfo3.FileName = "pt.exe";
                startInfo3.Arguments = "-ssh " + user + "@" + host + " " + port + " -pw " + pass + " -X -C";
                startInfo3.WindowStyle = ProcessWindowStyle.Minimized;

                pt3.StartInfo = startInfo3;

                
                pt3.Start();

                pt3.WaitForInputIdle();
                SetParent(pt3.MainWindowHandle, cliForm.cliConsole3.Handle);
                Utilities.HideMinimizeAndMaximizeButtons(pt3.MainWindowHandle);
                MoveWindow(pt3.MainWindowHandle, -8, -30, cliForm.cliConsole3.Width + 15, cliForm.cliConsole3.Height + 40, true);




                return true;

            }
            catch (Exception exp)
            {
                MessageBox.Show("Error : " + exp.Message);
                return false;
            }


        }


        internal void ShowForm()
        {
            cliForm.Show();
        }

    //---   FORM PROPERTIES,LOCATION AND SIZE-----------------------------------------------------------------------------------------------------------------------------------------
        public static string RandomString(int length = 8)
        {
            const string chars = "0123456789LMNOPQRSTUVWXYZABCDEFGHIJK";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void RestoreProperties(FormProps props)
        {
            cliForm.Top = props.positionTop;
            cliForm.Left = props.positionLeft;
            cliForm.Width = props.formWidth;
            cliForm.Height = props.formHeight;
            FormProperty.Screen = props.Screen;
           // FormProperty.ID = props.ID;
           
        }

        private void setFormLocation(Form form)
        {
           
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                if (Screen.AllScreens[i].DeviceName == FormProperty.Screen)
                {
                    form.Location = Screen.AllScreens[0].WorkingArea.Location;
                }
            }
            
        }

      
        internal static class Utilities
        {
            [DllImport("user32.dll")]
            internal extern static int SetWindowLong(IntPtr hwnd, int index, int value);

            [DllImport("user32.dll")]
            internal extern static int GetWindowLong(IntPtr hwnd, int index);

            internal static void HideMinimizeAndMaximizeButtons(IntPtr hwnd)
            {
                const int GWL_STYLE = -16;
                const int WS_SYSMENU = 0x80000;

                long value = GetWindowLong(hwnd, GWL_STYLE);
                SetWindowLong(hwnd, GWL_STYLE, (int)(value & ~WS_SYSMENU));

            }





        }



        private void onSaveProperty(object sender, EventArgs e)
        {
            MoveWindow(pt1.MainWindowHandle, -8, -30, cliForm.cliConsole1.Width + 15, cliForm.cliConsole1.Height + 40, true);
            MoveWindow(pt2.MainWindowHandle, -8, -30, cliForm.cliConsole2.Width + 15, cliForm.cliConsole2.Height + 40, true);
            MoveWindow(pt3.MainWindowHandle, -8, -30, cliForm.cliConsole3.Width + 15, cliForm.cliConsole3.Height + 40, true);
            saveProperties();
           


        }

      
        public void saveProperties()
        {
            FormProperty.positionLeft = cliForm.Left;
            FormProperty.positionTop = cliForm.Top;
            FormProperty.Screen = screen.DeviceName;
            FormProperty.formHeight = cliForm.Height;
            FormProperty.formWidth = cliForm.Width;
            if (FormProperty.ID == null) FormProperty.ID = RandomString();
            var configuration = Application.StartupPath + "/temp/config-" + FormProperty.ID + ".xml";
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

        private void onClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                var configuration = Application.StartupPath + "/temp/config-" + FormProperty.ID + ".xml";
                if (File.Exists(configuration))
                {
                    File.Delete(configuration);
                }
            }

        }

     //--------------------------------------------------------------------------------------------------------------------------------------
    }
    
}

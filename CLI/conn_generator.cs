using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CLI
{
     class conn_generator
    {

        Form1 form1;
        Screen screen2;
        public static Random random2 = new Random();
        private FormProps FormProperty2 = new FormProps();



       

        public conn_generator(FormProps props = null)
        {
            form1 = new Form1();
            screen2 = Screen.FromControl(form1);



            if (props != null)
            {
                RestoreProperties(props);
            }
            else
            {
               
                setFormLocation(form1);
            }
           
         
            
        }

        public void RestoreProperties(FormProps props)
        {
            form1.Top = props.positionTop;
            form1.Left = props.positionLeft;
            form1.Width = props.formWidth;
            form1.Height = props.formHeight;
            FormProperty2.Screen = props.Screen;
            form1.txtHost.Text = props.Host;
            form1.txtUsername.Text = props.User;
            form1.txtPassword.Text = props.Pass;
            form1.txtPort.Text = props.Port;

        }


        private void setFormLocation(Form form)
        {
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                if (Screen.AllScreens[i].DeviceName == FormProperty2.Screen)
                {
                    form.Location = Screen.AllScreens[0].WorkingArea.Location;
                }
            }

        }

        private void onSaveProperty(object sender, EventArgs e)
        {
            saveProperties();
        }


        public void saveProperties()
        {
            var configuration = Application.StartupPath + "/temp3/config.xml";
            if (File.Exists(configuration)) File.Delete(configuration);
            screen2 = Screen.FromControl(form1);

            FormProperty2.positionLeft = form1.Left;
            FormProperty2.positionTop = form1.Top;
            FormProperty2.Screen = screen2.DeviceName;
            FormProperty2.formHeight = form1.Height;
            FormProperty2.formWidth = form1.Width;
            // if (FormProperty2.ID == null) FormProperty2.ID = RandomString();
            if (!File.Exists(configuration))
            {
                using (StreamWriter w = File.AppendText(configuration)) { };
            }
            var xs = new XmlSerializer(FormProperty2.GetType());
            var ws = new XmlWriterSettings { Indent = true, NewLineOnAttributes = true, OmitXmlDeclaration = true };

            using (XmlWriter writer = XmlWriter.Create(configuration, ws))
            {
                xs.Serialize(writer, FormProperty2);
            }
        }

        public void ShowForm()
        {
            form1.Show();
        }


    }
}
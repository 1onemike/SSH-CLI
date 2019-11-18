using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;


namespace CLI
{
    class oe_gen
    {
        OE OE;
        Screen screen;
        private static Random random = new Random();
        public FormProps FormProperty = new FormProps();
      //  private bool atDomain = true;
        public oe_gen(FormProps props = null)
        {
            OE = new OE();
            screen = Screen.FromControl(OE);
            if (props != null)
            {
                RestoreProperties(props);
            }
            else
            {
                FormProperty.ID = RandomString();
                setFormLocation(OE);
            }
            OE.Move += new EventHandler(onSaveProperty);
            OE.Resize += new EventHandler(onSaveProperty);
            OE.FormClosing += new FormClosingEventHandler(onClosing);

            saveProperties();
        }



        private void onClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var configuration = Application.StartupPath + "/temp2/config-" + FormProperty.ID + ".xml";
                if (File.Exists(configuration))
                {
                    File.Delete(configuration);
                }
            }
        }

        public void ShowForm()
        {
            OE.Show();
        }

        private void onSaveProperty(object sender, EventArgs e)
        {
            saveProperties();
        }

        public static string RandomString(int length = 8)
        {
            const string chars = "0123456789LMNOPQRSTUVWXYZABCDEFGHIJK";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public void RestoreProperties(FormProps props)
        {
            OE.Top = props.positionTop;
            OE.Left = props.positionLeft;
            OE.Width = props.formWidth;
            OE.Height = props.formHeight;
            FormProperty.Screen = props.Screen;
        }

        public void saveProperties()
        {
            FormProperty.positionLeft = OE.Left;
            FormProperty.positionTop = OE.Top;
            FormProperty.Screen = screen.DeviceName;
            FormProperty.formHeight = OE.Height;
            FormProperty.formWidth = OE.Width;
            if (FormProperty.ID == null) FormProperty.ID = RandomString();
            var configuration = Application.StartupPath + "/temp2/config-" + FormProperty.ID + ".xml";
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

        private void setFormLocation(Form form)
        {
            // first method
            //Rectangle bounds = screen.Bounds;
            //form.SetBounds(bounds.X, bounds.Y, form.Width, form.Height);

            // second method
            //Point location = screen.Bounds.Location;
            //Size size = screen.Bounds.Size;

            //form.Left = location.X;
            //form.Top = location.Y;
            //form.Width = size.Width;
            //form.Height = size.Height;

            //third method
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                if (Screen.AllScreens[i].DeviceName == FormProperty.Screen)
                {
                    form.Location = Screen.AllScreens[0].WorkingArea.Location;
                }
            }

        }



    }
}
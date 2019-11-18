using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CLI
{
    public class FormProps
    {
        [XmlElement("positionTop")]
        public int positionTop { get; set; }

        [XmlElement("positionLeft")]
        public int positionLeft { get; set; }

        [XmlElement("formHeight")]
        public int formHeight { get; set; }

        [XmlElement("formWidth")]
        public int formWidth { get; set; }

        [XmlElement("ID")]
        public string ID { get; set; }

        [XmlElement("Screen")]
        public string Screen { get; set; }

        [XmlElement("Host")]
        public string Host { get; set; }

        [XmlElement("User")]
        public string User { get; set; }

        [XmlElement("Pass")]
        public string Pass { get; set; }

        [XmlElement("Port")]
        public string Port { get; set; }

        static public FormProps ConvertFromXMLString(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(FormProps));
            FormProps property = new FormProps();
            using (TextReader reader = new StringReader(xml))
            {
                property = (FormProps)serializer.Deserialize(reader);
            }
            return property;
        }
    }
}

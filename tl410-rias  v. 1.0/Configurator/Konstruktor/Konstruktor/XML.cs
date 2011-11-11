using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace Konstruktor
{
    class XML
    {
        string PATH;
        public XML(string path)
        {
            PATH = path;
        }

        private XmlDocument Load_xml(string file_name)
        {
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.Load(file_name);
            return xml_doc;
        }

        public string[] load_settings(string file_settings)
        {
            XmlDocument xml_doc = Load_xml(file_settings);
            string[] settings = new string[xml_doc.DocumentElement.ChildNodes.Count];
            for (int i = 0; i < xml_doc.DocumentElement.ChildNodes.Count; i++)
            {
                settings[i] = xml_doc.DocumentElement.ChildNodes[i].ChildNodes[0].Value;
            }
            return settings;
        }

        private void new_actions_xml_file(string filename)
        {
            File.Copy(PATH + @"\temp.xml", filename);
        }

        public void add_actions(string filename, string[] settings)
        {
            new_actions_xml_file(filename);
            XmlDocument xml_message_file = new XmlDocument();
            xml_message_file.Load(filename);

            for (int i = 0; i < settings.Length; i++)
            {
                XmlElement elem = xml_message_file.CreateElement("action");
                XmlText text = xml_message_file.CreateTextNode(settings[i]);
                xml_message_file.DocumentElement.AppendChild(elem);
                xml_message_file.DocumentElement.LastChild.AppendChild(text);

                xml_message_file.Save(filename);
            }
        }
    }
}

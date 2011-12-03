using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
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

        protected XDocument LoadDocument(string filename)
        {
            XmlDocument docxml = new XmlDocument();
            docxml.Load(filename);
            XmlNodeReader nodeReader = new XmlNodeReader(docxml);
            XDocument xDoc = XDocument.Load(nodeReader);
            return xDoc;
        }

        protected string GetScenarioName(XDocument doc)
        {
            string scen_name;
            scen_name = doc.Element("scenario").Element("name_scenario").Value;
            return scen_name;
        }

        protected Events[] GetScenarioActions(XDocument doc)
        {
            int count = doc.Element("scenario").Element("actions").Elements().Count();
            int index = 0;
            Events[] events = new Events[count];
            IEnumerable<XElement> elements =
                from el in doc.Element("scenario").Element("actions").Elements()
                select el;
            foreach (XElement el in elements)
            {
                events[index] = ElementToEvent(el);
                index++;         
            }
            return events;
        }

        protected Events GetScenarioAction(XDocument doc, string name_event)
        {
            Events myevent = new Events();
            IEnumerable<XElement> elements =
                from el in doc.Element("scenario").Element("actions").Elements()
                where (string)el.Element("name") == name_event
                select el;
            foreach (XElement el in elements)
            {
                myevent = ElementToEvent(el);
                break;
            }
            return myevent;
        }

        protected XDocument EditNameScenario(XDocument doc, string name_scenario)
        {
            doc.Element("scenario").Element("name_scenario").Value = name_scenario;
            return doc;
        }

        protected XDocument EditEvent(XDocument doc, string name_event, Events my_event)
        {
            IEnumerable<XElement> elements =
                from el in doc.Element("scenario").Element("actions").Elements()
                where (string)el.Element("name") == name_event
                select el;
            foreach (XElement el in elements) 
            {
                el.Element("name").Value = my_event.Name;
                el.Element("script").Value = my_event.Script;
                el.Element("is_single").Value = my_event.IsSingle.ToString();
                el.Element("interval").Value = my_event.Interval.ToString();
                break;
            }
            return doc;
        }

        protected XDocument EditEvents(XDocument doc, Events[] my_events)
        {
            doc.Element("scenario").Element("actions").Elements().Remove();
            for(int i = 0; i < my_events.Length; i++ )
            {
                XElement elem = EventToElement(my_events[i]);
                AddEventToScenario(doc, elem);
            }
            return doc;
        }

        protected XDocument DeleteEvent(XDocument doc, string name_event)
        {
            IEnumerable<XElement> elements =
                from el in doc.Element("scenario").Element("actions").Elements()
                where (string)el.Element("name") == name_event
                select el;
            foreach (XElement el in elements)
            {
                el.Remove();
                break;
            }
            return doc;
        }

        protected void SaveScenario(XDocument doc, string filename)
        {
            doc.Save(filename);
        }

        protected XDocument AddEventToScenario(XDocument doc, XElement elem)
        {
            doc.Element("scenario").Element("actions").Add(elem);
            return doc;
        }

        protected XElement EventToElement(Events my_event)
        {
            XElement elem = new XElement("action");
            elem.Add(new XElement("name", my_event.Name));
            elem.Add(new XElement("script", my_event.Script));
            elem.Add(new XElement("is_single", my_event.IsSingle));
            elem.Add(new XElement("interval", my_event.Interval));
            return elem;
        }

        protected XDocument NewScenario(string scenario_name)
        {
            XDocument doc = new XDocument(
                new XElement("scenario",
                    new XElement("name_scenario", scenario_name),
                    new XElement("actions")
                )
            );
            return doc;
        }

        protected Events ElementToEvent(XElement elem)
        {
            Events myevent = new Events();
            myevent.Name = elem.Element("name").Value;
            myevent.Script = elem.Element("script").Value;
            myevent.IsSingle = Convert.ToBoolean(elem.Element("is_single").Value);
            myevent.Interval = Convert.ToInt16(elem.Element("interval").Value);
            return myevent;
        }

    }
}

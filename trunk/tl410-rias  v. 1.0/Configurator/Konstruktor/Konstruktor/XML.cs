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

        protected XDocument LoadDocument(string filename)//Завантажуємо документ з ім'ям filename в обєкт XDocument
        {
            XmlDocument docxml = new XmlDocument();
            docxml.Load(filename);
            XmlNodeReader nodeReader = new XmlNodeReader(docxml);
            XDocument xDoc = XDocument.Load(nodeReader);
            return xDoc;
        }

        protected string GetScenarioName(XDocument doc)//Дістаємо зі сценарію у форматі XDocument ім'я сценарію 
        {
            string scen_name;
            scen_name = doc.Element("scenario").Element("name_scenario").Value;
            return scen_name;
        }

        protected Events[] GetScenarioEvents(XDocument doc)//Дістаємо зі сценарію у форматі XDocument масив подій Events[] events
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

        protected Events GetScenarioEvent(XDocument doc, string name_event)//Дістаємо зі сценарію у форматі XDocument одну подію з ім'ям name_event
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

        protected XDocument EditNameScenario(XDocument doc, string name_scenario)//Змінюємо ім'я сценарію на name_scenario
        {
            doc.Element("scenario").Element("name_scenario").Value = name_scenario;
            return doc;
        }

        protected XDocument EditEvent(XDocument doc, string name_event, Events my_event)//Змінюємо подію з ім'ям name_event на my_event
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

        protected XDocument EditEvents(XDocument doc, Events[] my_events)//Змінюємо масив подій на масив Events[] my_events
        {
            doc.Element("scenario").Element("actions").Elements().Remove();
            for(int i = 0; i < my_events.Length; i++ )
            {
                XElement elem = EventToElement(my_events[i]);
                AddEventToScenario(doc, elem);
            }
            return doc;
        }

        protected XDocument DeleteEvent(XDocument doc, string name_event)//Видаляємо одну подію зі з ім'ям name_event 
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

        protected void SaveScenario(XDocument doc, string filename)//Зберігаємо сценарій в файл з ім'ям filename
        {
            doc.Save(filename);
        }

        protected XDocument AddEventToScenario(XDocument doc, XElement elem)//Додаємо в кінець сценарію ще одну подію в форматі XElement elem
        {
            doc.Element("scenario").Element("actions").Add(elem);
            return doc;
        }

        protected XElement EventToElement(Events my_event)//Конвертуємо подію з формату Events в формат XElement
        {
            XElement elem = new XElement("action");
            elem.Add(new XElement("name", my_event.Name));
            elem.Add(new XElement("script", my_event.Script));
            elem.Add(new XElement("is_single", my_event.IsSingle));
            elem.Add(new XElement("interval", my_event.Interval));
            return elem;
        }

        protected XDocument NewScenario(string scenario_name)//Створюємо шаблон нового порожньго сценарію з ім'ям сценарыю scenario_name
        {
            XDocument doc = new XDocument(
                new XElement("scenario",
                    new XElement("name_scenario", scenario_name),
                    new XElement("actions")
                )
            );
            return doc;
        }

        protected Events ElementToEvent(XElement elem)//Конвертуємо подію з формату XElement в формат  Events
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

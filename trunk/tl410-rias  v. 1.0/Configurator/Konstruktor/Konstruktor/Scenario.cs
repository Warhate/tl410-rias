using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Text;
using System.IO;

namespace Konstruktor
{
    class Scenario:XML
    {

        public Scenario(string path) : base(path)
        {
        }

        public void test()
        {
            XDocument doc = LoadDocument("temp.xml");
            Events eve = GetScenarioAction(doc, "test3");
            eve.Interval = 60;
            eve.IsSingle = false;
            eve.Name = "text";
            eve.Script = "df";
            doc = EditNameScenario(doc, "temp");
            doc = EditEvent(doc, "test3", eve);
            doc = DeleteEvent(doc, "test4");
            XElement elem = EventToElement(eve);
            doc = AddEventToScenario(doc, elem);
            SaveScenario(doc, "temp.xml");
        }

        public void New_Scenario(string filename, Scenarios scen)
        {
            XDocument doc = NewScenario(scen.Name);
            XElement elem;
            for (int i = 0; i < scen.ListEvents.Length; i++)
            {
                elem = EventToElement(scen.ListEvents[i]);
                AddEventToScenario(doc, elem);
                elem = null;
            }
            SaveScenario(doc, filename);
        }

        public void Edit_Scenario(string filename, Scenarios scen)
        {
            XDocument doc = LoadDocument(filename);
            doc = EditNameScenario(doc, scen.Name);
            doc = EditEvents(doc, scen.ListEvents);
            SaveScenario(doc, filename);
        }

        public void Delete_Scenario(string filename)
        {
            File.Delete(filename);
        }

        public Scenarios Get_Scenario(string filename)
        {
            Scenarios scenario = new Scenarios();
            XDocument doc = LoadDocument(filename);
            scenario.Name = GetScenarioName(doc);
            scenario.ListEvents = GetScenarioActions(doc);
            return scenario;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Logsaver
{
    public class LogStorage
    {
        string date = " ";
        List<string> parList = new List<string>();
        public string getLog(string log)
        {
            DateTime dt = DateTime.Now;
            if (date == dt.ToShortDateString())
            {  
                log = "           " + dt.ToLongTimeString() + " " + log + "\r\n";
            }
            else
            {
                date = dt.ToShortDateString();
                log = "\r\n" + date + "\r\n" + "           " + dt.ToLongTimeString() + " " + log + "\r\n";
            }
            return log;
        }
        public bool checkAddList(string name,string value)
        {           
            if (parList.Contains(name+value))
            {
                return false;
            }
            else
            {
                parList.Add(name + value);
                return true;
            }
        }
        public void saveAll(string name, string value)
        {
            if (checkAddList(name, value))
            {
                saveStr(name +" "+ value);
            }
        }
        public void saveStr(string log)
        {
            StreamWriter SW = new StreamWriter(new FileStream("Log.txt", FileMode.Append, FileAccess.Write));
            SW.Write(getLog(log));
            SW.Close();
        }
    }
}

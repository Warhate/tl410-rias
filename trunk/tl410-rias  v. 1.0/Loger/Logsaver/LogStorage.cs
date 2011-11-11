using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Logsaver
{
    public abstract class LogStorage
    {
        private string Log;
        public string getLog()
        {
            return Log;
        }
        public void setLog(string newLog)
        {
            Log = System.DateTime.Now + " " + newLog + "\r\n";
        }
        public void saveStr()
        {
            StreamWriter SW = new StreamWriter(new FileStream("Log.txt", FileMode.Append, FileAccess.Write));
            SW.Write(getLog());
            SW.Close();
        }
    }
}

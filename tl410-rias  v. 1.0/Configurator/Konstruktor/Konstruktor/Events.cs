using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Konstruktor
{
    struct Events
    {
        public string Name;
        public string Script;
        public bool IsSingle;
        public int Interval;
    }

    struct Scenarios
    {
        public string Name;
        public Events[] ListEvents;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetRomeo.Class
{
    public class Sessions
    {
        public class Messages
        {
            public DateTime last_activity { get; set; }
            public int counter { get; set; }
            public int counter_since_last_access { get; set; }
            public DateTime last_inbox_activity { get; set; }
        }

        public class Favorites
        {
            public int counter { get; set; }
            public int counter_since_last_access { get; set; }
            public int counter_romeos { get; set; }
            public int counter_escorts { get; set; }
            public int counter_clubs { get; set; }
            public int counter_romeos_since_last_access { get; set; }
            public int counter_escorts_since_last_access { get; set; }
            public int counter_clubs_since_last_access { get; set; }
        }

        public class Visitors
        {
            public int counter { get; set; }
            public int counter_since_last_access { get; set; }
        }

        public class ResponseSession
        {
            public Messages messages { get; set; }
            public Favorites favorites { get; set; }
            public Visitors visitors { get; set; }
            public string online_status { get; set; }
        }
    }
}

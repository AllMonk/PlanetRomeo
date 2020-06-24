using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetRomeo.Class
{
    public class SetContact
    {
        public class ResponseContact
        {
            public string note { get; set; }
            public bool favourite { get; set; }
            public bool known { get; set; }
            public bool linked { get; set; }
            public List<object> tags { get; set; }
            public DateTime date_created { get; set; }
            public string profile { get; set; }
        }
        public class Setcontact
        {
            public Setcontact(string favourite, string known, string linked, string note, string profile)
            {
                this.favourite = favourite ?? throw new ArgumentNullException(nameof(favourite));
                this.known = known ?? throw new ArgumentNullException(nameof(known));
                this.linked = linked ?? throw new ArgumentNullException(nameof(linked));
                this.note = note ?? throw new ArgumentNullException(nameof(note));
                this.profile = profile ?? throw new ArgumentNullException(nameof(profile));
            }

            public string favourite { get; set; }
            public string known { get; set; }
            public string linked { get; set; }
            public string note { get; set; }
            public string profile { get; set; }
        }
    }
}

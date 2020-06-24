using System;

namespace PlanetRomeo.Class
{
    public partial class ProfileWork
    {
        public class SendLike
        {
            public SendLike(string value, string element_id)
            {
                this.value = value ?? throw new ArgumentNullException(nameof(value));
                this.element_id = element_id ?? throw new ArgumentNullException(nameof(element_id));
            }

            public string value { get; set; }
            public string element_id { get; set; }
        }
    }
}

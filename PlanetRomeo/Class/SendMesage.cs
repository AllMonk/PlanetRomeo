using System;

namespace PlanetRomeo.Class
{
    public partial class Messages
    {
        public class SendMesage
        {
            public SendMesage(string to, string text)
            {
                this.to = to ?? throw new ArgumentNullException(nameof(to));
                this.text = text ?? throw new ArgumentNullException(nameof(text));
            }

            public string to { get; set; }
            public string text { get; set; }
        }
    }
}

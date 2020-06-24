using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetRomeo.Class
{
    public partial class Messages
    {
        public class Cursors
        {
            public string after { get; set; }
            public string befory { get; set; }
        }

        public class Location
        {
            public string name { get; set; }
            public string country { get; set; }
            public int distance { get; set; }
            public bool sensor { get; set; }
        }

        public class PreviewPic
        {
            public string id { get; set; }
            public string owner_id { get; set; }
            public string url_token { get; set; }
            public string auth_token { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string rating { get; set; }
            public bool is_public { get; set; }
        }

        public class Personal
        {
            public int age { get; set; }
            public int height { get; set; }
            public int weight { get; set; }
        }

        public class To
        {
            public string headline { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string online_status { get; set; }
            public DateTime last_login { get; set; }
            public Location location { get; set; }
            public PreviewPic preview_pic { get; set; }
            public bool is_official { get; set; }
            public bool is_deactivated { get; set; }
            public bool can_video_call { get; set; }
            public Personal personal { get; set; }
            public bool blocked { get; set; }
        }

        public class Location2
        {
            public string name { get; set; }
            public string country { get; set; }
            public int distance { get; set; }
            public bool sensor { get; set; }
        }

        public class PreviewPic2
        {
            public string id { get; set; }
            public string owner_id { get; set; }
            public string url_token { get; set; }
            public string auth_token { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string rating { get; set; }
            public bool is_public { get; set; }
        }

        public class Personal2
        {
            public int age { get; set; }
            public int height { get; set; }
            public int weight { get; set; }
        }

        public class Footprint
        {
            public string received { get; set; }
        }

        public class From
        {
            public string headline { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string online_status { get; set; }
            public DateTime last_login { get; set; }
            public Location2 location { get; set; }
            public PreviewPic2 preview_pic { get; set; }
            public bool is_official { get; set; }
            public bool is_deactivated { get; set; }
            public bool can_video_call { get; set; }
            public Personal2 personal { get; set; }
            public bool blocked { get; set; }
            public Footprint footprint { get; set; }
        }

        public class Params
        {
            public string id { get; set; }
            public string owner_id { get; set; }
            public string url_token { get; set; }
            public string auth_token { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string rating { get; set; }
            public bool is_public { get; set; }
        }

        public class Attachment
        {
            public string type { get; set; }
            public Params @params { get; set; }
        }

        public class Item
        {
            public To to { get; set; }
            public string text { get; set; }
            public string id { get; set; }
            public From from { get; set; }
            public DateTime date { get; set; }
            public DateTime expires { get; set; }
            public string folder { get; set; }
            public bool unread { get; set; }
            public bool locked { get; set; }
            public bool spam { get; set; }
            public List<Attachment> attachments { get; set; }
        }

        public class GetMessages
        {
            public Cursors cursors { get; set; }
            public List<Item> items { get; set; }
            public int items_total { get; set; }
        }
    }
}

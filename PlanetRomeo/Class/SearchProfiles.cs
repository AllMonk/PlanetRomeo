using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetRomeo.Class
{
    public class SearchProfiles
    {
        public class Cursors
        {
            public string after { get; set; }
        }

        public class Travel
        {
            public string id { get; set; }
            public DateTime date_start { get; set; }
            public DateTime date_end { get; set; }
            public string comment { get; set; }
        }

        public class Location
        {
            public string name { get; set; }
            public string country { get; set; }
            public int distance { get; set; }
            public bool sensor { get; set; }
            public Travel travel { get; set; }
        }

        public class PreviewPic
        {
            public string id { get; set; }
            public string url_token { get; set; }
            public string auth_token { get; set; }
            public string rating { get; set; }
        }

        public class Display
        {
            public bool large_tile { get; set; }
        }

        public class Sexual
        {
            public bool enabled { get; set; }
            public string favored_position { get; set; }
            public string anal_position { get; set; }
            public string dick_size { get; set; }
            public string concision { get; set; }
            public string dirty_sex { get; set; }
            public string sm { get; set; }
            public string fisting { get; set; }
            public List<string> fetish { get; set; }
            public string safer_sex { get; set; }
        }

        public class TargetAge
        {
            public int min { get; set; }
            public int? max { get; set; }
        }

        public class Personal
        {
            public int age { get; set; }
            public int height { get; set; }
            public int weight { get; set; }
            public TargetAge target_age { get; set; }
            public string profile_text { get; set; }
            public string beard { get; set; }
            public string body_hair { get; set; }
            public string body_type { get; set; }
            public string ethnicity { get; set; }
            public string eye_color { get; set; }
            public string hair_length { get; set; }
            public string hair_color { get; set; }
            public string orientation { get; set; }
            public string smoker { get; set; }
            public string piercing { get; set; }
            public string tattoo { get; set; }
            public List<string> spoken_languages { get; set; }
            public string relationship { get; set; }
            public List<string> looking_for { get; set; }
        }

        public class Item
        {
            public string type { get; set; }
            public string headline { get; set; }
            public string id { get; set; }
            public string online_status { get; set; }
            public DateTime last_login { get; set; }
            public string name { get; set; }
            public Location location { get; set; }
            public bool can_video_call { get; set; }
            public bool is_new { get; set; }
            public PreviewPic preview_pic { get; set; }
            public bool is_official { get; set; }
            public Display display { get; set; }
            public bool bed_and_breakfast { get; set; }
            public Sexual sexual { get; set; }
            public Personal personal { get; set; }
        }

        public class SearchFilter
        {
            public Cursors cursors { get; set; }
            public List<Item> items { get; set; }
            public int items_total { get; set; }
        }
    }
}

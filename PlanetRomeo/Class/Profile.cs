using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetRomeo.Class
{
    public class Profile
    {
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

        public class TargetAge
        {
            public int min { get; set; }
            public int max { get; set; }
        }

        public class Personal
        {
            public int height { get; set; }
            public int weight { get; set; }
            public TargetAge target_age { get; set; }
            public List<string> looking_for { get; set; }
            public string profile_text { get; set; }
            public string body_hair { get; set; }
            public string body_type { get; set; }
            public string ethnicity { get; set; }
            public string relationship { get; set; }
            public string orientation { get; set; }
            public List<string> spoken_languages { get; set; }
            public int age { get; set; }
        }

        public class Sexual
        {
            public bool enabled { get; set; }
            public string anal_position { get; set; }
            public string dick_size { get; set; }
            public string concision { get; set; }
            public string safer_sex { get; set; }
        }

        public class Hobby
        {
            public bool enabled { get; set; }
        }

        public class DisplayOptions
        {
            public bool show_plus { get; set; }
            public bool show_donation_badge { get; set; }
        }

        public class KnownBy
        {
            public int first_degree { get; set; }
            public int second_degree { get; set; }
        }

        public class Item
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

        public class Album
        {
            public string access_policy { get; set; }
            public string preview_pic { get; set; }
            public string id { get; set; }
            public string owner_id { get; set; }
            public List<Item> items { get; set; }
            public int items_total { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public DateTime? last_modified { get; set; }
            public string restriction { get; set; }
        }
        public class UserProfile
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
            public Sexual sexual { get; set; }
            public Hobby hobby { get; set; }
            public DateTime creation_date { get; set; }
            public bool is_new { get; set; }
            public int visits_count { get; set; }
            public DisplayOptions display_options { get; set; }
            public string authenticity { get; set; }
            public KnownBy known_by { get; set; }
            public List<Album> albums { get; set; }
        }
    }
}

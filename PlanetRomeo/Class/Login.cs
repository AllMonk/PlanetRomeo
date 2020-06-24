using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetRomeo.Class
{
    public class Login
    {
        public class RequestLogin
        {
            public RequestLogin(string username, string password)
            {
                this.username = username ?? throw new ArgumentNullException(nameof(username));
                this.password = password ?? throw new ArgumentNullException(nameof(password));
            }

            public string username { get; set; }
            public string password { get; set; }
        }
        public class Account
        {
            public string name { get; set; }
            public string email { get; set; }
            public string id { get; set; }
            public bool is_activated { get; set; }
            public bool user_set_password { get; set; }
            public List<object> providers { get; set; }
        }

        public class Location
        {
            public string name { get; set; }
            public string country { get; set; }
            public int distance { get; set; }
            public bool sensor { get; set; }
            public string name_details { get; set; }
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
            public int height { get; set; }
            public int weight { get; set; }
            public List<string> looking_for { get; set; }
            public string profile_text { get; set; }
            public string body_hair { get; set; }
            public string body_type { get; set; }
            public string ethnicity { get; set; }
            public string relationship { get; set; }
            public string orientation { get; set; }
            public List<string> spoken_languages { get; set; }
            public int age { get; set; }
            public DateTime birthdate { get; set; }
        }

        public class Sexual
        {
            public bool enabled { get; set; }
        }

        public class Hobby
        {
            public bool enabled { get; set; }
        }

        public class KnownBy
        {
            public int first_degree { get; set; }
            public int second_degree { get; set; }
        }

        public class DisplayOptions
        {
            public bool show_plus { get; set; }
            public bool show_donation_badge { get; set; }
        }

        public class Profile
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
            public Sexual sexual { get; set; }
            public Hobby hobby { get; set; }
            public bool is_activated { get; set; }
            public string authenticity { get; set; }
            public KnownBy known_by { get; set; }
            public DateTime creation_date { get; set; }
            public int visits_count { get; set; }
            public DisplayOptions display_options { get; set; }
            public bool email_verified { get; set; }
        }

        public class Album
        {
            public string access_policy { get; set; }
            public string preview_pic { get; set; }
            public string id { get; set; }
            public string owner_id { get; set; }
            public List<object> items { get; set; }
            public int items_total { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public DateTime? last_modified { get; set; }
        }

        public class Capabilities
        {
            public bool can_purchase { get; set; }
            public bool can_see_plus_history { get; set; }
            public bool can_buy_recurring_plus { get; set; }
            public bool can_hide_headlines { get; set; }
            public bool can_hide_visit { get; set; }
            public bool can_see_hardcore_pictures { get; set; }
            public bool can_set_plus_radar_style { get; set; }
            public bool can_save_unlimited_searches { get; set; }
            public bool can_save_unlimited_contacts { get; set; }
            public bool can_set_invisible_online_status { get; set; }
            public bool can_use_unlimited_album_sharing { get; set; }
            public bool can_set_email_notifications { get; set; }
            public bool can_set_travel_info { get; set; }
            public bool can_see_travel_profiles { get; set; }
            public bool can_see_escort_profiles { get; set; }
            public bool can_see_escort_dashboard { get; set; }
            public bool can_share_referral { get; set; }
            public bool can_react_to_pictures { get; set; }
            public bool can_use_video_calling { get; set; }
            public bool can_use_sift_sdk { get; set; }
            public bool can_use_groups { get; set; }
            public bool can_use_message_templates { get; set; }
        }

        public class ResponseLogin
        {
            public string user_id { get; set; }
            public string username { get; set; }
            public string session_id { get; set; }
            public string online_status { get; set; }
            public bool is_plus { get; set; }
            public bool is_free_plus { get; set; }
            public string payment_group { get; set; }
            public bool confirmed_account { get; set; }
            public Account account { get; set; }
            public Profile profile { get; set; }
            public List<Album> albums { get; set; }
            public Capabilities capabilities { get; set; }
            public string error_message { get; set; }
            public string error_code { get; set; }
            public string context { get; set; }
        }
    }
}

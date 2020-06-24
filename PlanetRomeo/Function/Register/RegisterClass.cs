using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetRomeo.Function.Register
{
    public class Error
    {
        public string message { get; set; }
        public string code { get; set; }
        public string parameter { get; set; }
        public string value { get; set; }
    }

    public class ValidationResponse
    {
        public List<Error> errors { get; set; }
        public int password_strength { get; set; }
    }
    public class Location
    {
        public string lat { get; set; }
        public string lon { get; set; }
    }

    public class GeocoderResponse
    {
        public Location location { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }
    public class ValidationRequet
    {
        public DateTime birthdate { get; set; }
        public string email { get; set; }
        public string language { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string type { get; set; }
    }

    public class Address
    {
        public string address { get; set; }
        public int state { get; set; }
        public int time { get; set; }
        public int retry { get; set; }
    }

    public class RegisterClass
    {
        public class Location
        {
            public string name { get; set; }
            public double lat { get; set; }
            public double @long { get; set; }
            public string region { get; set; }
            public Address address { get; set; }
            public bool sensor { get; set; }
        }

        public class RegisterRequest
        {
            public string birthdate { get; set; }
            public string email { get; set; }
            public string language { get; set; }
            public Location location { get; set; }
            public string name { get; set; }
            public string password { get; set; }
            public string type { get; set; }
        }


        public class RegisterRequestResponse
        {
            public string user_id { get; set; }
            public string username { get; set; }
            public string session_id { get; set; }
            public string online_status { get; set; }
            public bool is_plus { get; set; }
            public bool is_free_plus { get; set; }
            public string payment_group { get; set; }
            public bool confirmed_account { get; set; }
        }
    }
}

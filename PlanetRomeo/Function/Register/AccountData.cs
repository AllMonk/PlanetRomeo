using System;
using System.Collections.Generic;
using System.Text;
using PlanetRomeo.Function.Register;
using xNet;
using Newtonsoft.Json;

namespace PlanetRomeo.Function.Register
{
    public class RegisreResponse
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

    public class AccountData
    {
        public RegisterClass AccountRegisterData { get; set; }
        public DateTime RegisterTime { get; set; }
        public RegisreResponse RegisterResponse { get; set; }
        public int CompleteView { get; set; }
        public int CompleteSendMess { get; set; }
        public int SessionView { get; set; }
        public int SessionSendMess { get; set; }
    }
    
    public class Register
    {
        public AccountData RegisterAccount ()
        {
            AccountData acc = null;
            HttpRequest req = new HttpRequest();
            req.KeepAlive = true;
            req["x-api-key"] = "vuEp8o93b34CxUCljSMFEdhI70qDWtuk";
            req["x-site"] = "planetromeo";
            req["X-Requested-With"] = "XMLHttpRequest";
            //req["x-api-key"] = "M0iGVpi2C4MZGdYSGYQDx5Oy3pts6SJa";
            req[HttpHeader.Accept] = "application/json";
            req[HttpHeader.AcceptCharset] = "utf-8";
            req[HttpHeader.AcceptLanguage] = "en";
            req.UserAgent = "PlanetRomeo/1000000536 Android/5.1.1 (samsung; SM-G930L)";
            req.Referer = "https://www.planetromeo.com/signup/terms";
            RegisterClass.RegisterRequest register = new RegisterClass.RegisterRequest();
            register.birthdate = "1995-06-23T11:04:44+0300";
            register.email = "Natal456iyaDzhivalova2575@mail.ru";
            register.language = "ru";
            register.location = new RegisterClass.Location();
            register.location.name = "";
            register.location.lat = 30.33566342119686;
            register.location.@long = -91.30505595356226;
            register.location.address = new Address();
            register.location.address.address = "";
            register.location.address.state = 0;
            register.location.address.time = 0;
            register.location.address.retry = 0;
            register.location.sensor = false;
            register.name = "natalD456vg12";
            register.password = "F223f54vdsgsR#2g";
            register.type = "ROMEO";

            string GoogleToken = "03AGdBq2411ohKUrUmtnx5OfsLU_5c9kMPNl3UCbmASAcgt_qk3SFefGD5L7l-nDkYK-D3GJqe2-MDxIf1J8Er2KsXxTRO62UvDiN3y7IOVcn6ZiikGs7xveF71K9KjRSYA7kLo5REXcosM4Ovbe0n4hR4gOOVDefu5gvwBBluKOC9ZSvpWOsrWC_X8oMyXqVJvRYnXpMvr2gn4yEEfkApLjnNxcdd3XIMPJZ8TBefb6rpYVdpgn7cD8pNv9zUDeM4PkV_cQoD0y7y6mmYrNsoHbxkpeIBOXE_1NiQ2wLDGOLmnPBnCqwR2AA0cF-2Pkl9AI_xHqJgyfQZv5FO8bB4k1x9f1eSWuadoH-qzkY_FBluIhDh0maFarrR_sl_O5-jIYcBcgP3_H0weDb-uNnSZ84Hd5IDH-syiA";
            
            string LinkReg = $@"https://www.planetromeo.com/api/v4/account?token_provider=GOOGLE_RECAPTCHA&security_token={GoogleToken}";//?security_token={GoogleToken}&token_provider=GOOGLE_RECAPTCHA";
            HttpResponse res = null;
            try
            {
                res = req.Post(LinkReg, JsonConvert.SerializeObject(register), "application/json");
                Console.WriteLine(res.ToString());
            }
            catch (HttpException ex)
            {
                Console.WriteLine(req.Response.ToString());
            }
            return acc;
        }
    }
}

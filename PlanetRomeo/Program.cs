using System;
using System.Text.RegularExpressions;
using xNet;
using Newtonsoft.Json;
using PlanetRomeo.Class;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;
using PlanetRomeo.Function.Register;

namespace PlanetRomeo
{
    public class Program
    {
        static List<Profile.UserProfile> people = new List<Profile.UserProfile>();
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");
            if (!Directory.Exists("Parser"))
                Directory.CreateDirectory("Parser");
            if (!Directory.Exists("Parser\\Photos"))
                Directory.CreateDirectory("Parser\\Photos");
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
            //string GoogleToken = "";
            string LinkReg = $@"https://www.planetromeo.com/api/v4/account?token_provider=GOOGLE_RECAPTCHA&security_token={GoogleToken}";//?security_token={GoogleToken}&token_provider=GOOGLE_RECAPTCHA";
            HttpResponse res = null;
            try
            {
                res = req.Post(LinkReg, JsonConvert.SerializeObject(register), "application/json");
                Console.WriteLine(res.ToString());
            }
            catch(HttpException ex)
            {
                Console.WriteLine(req.Response.ToString());
            }
            /*Login.RequestLogin requestLogin = new Login.RequestLogin("Arcady","Myaso_121");
            Console.WriteLine("Send login request");
            Login.ResponseLogin responseLogin = JsonConvert.DeserializeObject<Login.ResponseLogin>(req.Post(@"https://pradn.net/v4/session?expand=account,profile,albums,capabilities", JsonConvert.SerializeObject(requestLogin), "application/json; charset=UTF-8").ToString());
            Console.WriteLine(JsonConvert.SerializeObject(responseLogin));
            if (string.IsNullOrEmpty(responseLogin.error_code))
            {
                Console.WriteLine("GoodAuth");
                Console.WriteLine("Send Session request");
                req["x-session-id"] = responseLogin.session_id;
                Sessions.ResponseSession responseSession = JsonConvert.DeserializeObject<Sessions.ResponseSession>(req.Raw(xNet.HttpMethod.PUT, "https://pradn.net/v4/session").ToString());
                Console.WriteLine(JsonConvert.SerializeObject(responseSession));

                /*List<Messages.GetMessages> MessList = new List<Messages.GetMessages>();
                Messages.GetMessages getMessages = JsonConvert.DeserializeObject<Messages.GetMessages>(req.Get("https://pradn.net/v4/messages?length=30&filter%5Bfolders%5D%5B%5D=RECEIVED&filter%5Bfolders%5D%5B%5D=SENT&filter%5Bfolders%5D%5B%5D=SPAM&expand=items.*.(to%2Cfrom)").ToString()) ;
                MessList.Add(getMessages);
                File.AppendAllText(@"Messages.json", JsonConvert.SerializeObject(getMessages) + "\r\n");
                while (!string.IsNullOrEmpty(getMessages.cursors.after))
                {
                    getMessages = JsonConvert.DeserializeObject<Messages.GetMessages>(req.Get($"https://pradn.net/v4/messages?length=30&cursor={getMessages.cursors.after}&filter%5Bfolders%5D%5B%5D=RECEIVED&filter%5Bfolders%5D%5B%5D=SENT&expand=items.*.(to%2Cfrom)").ToString());
                    MessList.Add(getMessages);
                    File.AppendAllText(@"Messages.json", JsonConvert.SerializeObject(getMessages) + "\r\n");
                }
                Console.WriteLine($"Found {getMessages.items_total} messages");
                List<string> UserID = new List<string>();
                List<string> UserTemp = new List<string>();
                foreach (var item in MessList)
                {
                    foreach (var itemMess in item.items)
                    {
                        UserTemp.Add(itemMess.from.id);
                    }
                }
                UserID.AddRange(UserTemp.Distinct());
                Console.WriteLine($"Найдено {UserID.Count} уникальных диалог/а/ов");
                foreach (var uid in UserID)
                {
                    Messages.SendMesage mess = new Messages.SendMesage(uid, "Hello. Check my description =) you will like it: P");
                    SetContact.Setcontact Contact = new SetContact.Setcontact("true","false", "false", "", uid);
                    Console.WriteLine($"Send mess to {JsonConvert.SerializeObject(mess)}   response:");
                    try
                    {
                        Console.WriteLine("\t\t" + req.Post("https://pradn.net/v4/messages", JsonConvert.SerializeObject(mess), "application/json; charset=utf-8"));
                        Thread.Sleep(500);
                        SetContact.ResponseContact ResponseContact = JsonConvert.DeserializeObject<SetContact.ResponseContact>(req.Post("https://pradn.net/v4/contacts", JsonConvert.SerializeObject(Contact), "application/json; charset=utf-8").ToString());
                        Console.WriteLine("Set Contact response: " + JsonConvert.SerializeObject(ResponseContact));
                        Thread.Sleep(1000);
                    }
                    catch { continue; }
                }*/
            /*SearchProfiles.SearchFilter x = JsonConvert.DeserializeObject<SearchProfiles.SearchFilter>(req.Get("https://pradn.net/v4/profiles/?length=20&filter%5Blocation%5D%5Blong%5D=-73.996086&filter%5Btravellers_filter%5D=TRAVELLERS_ONLY&filter%5Blocation%5D%5Blat%5D=40.729027&scrollable=false&filter%5Bbed_and_breakfast_filter%5D=WITHOUT&filter%5Bwith_picture%5D=true&sort_criteria=NEARBY_ASC").ToString());

            foreach (var item in x.items)
            {
                Program program = new Program();
                program.GetInfo(responseLogin.session_id, item);
                Thread.Sleep(700); 
                Console.WriteLine($"{DateTime.Now.ToString()}\tFind {people.Count} peoples total");;

            }
            req.Raw(xNet.HttpMethod.PUT, "https://pradn.net/v4/session");
            while (!string.IsNullOrEmpty(x.cursors.after))
            {
                x = JsonConvert.DeserializeObject<SearchProfiles.SearchFilter>(req.Get($"https://pradn.net/v4/profiles/?scrollable=true&cursor={x.cursors.after}").ToString());
                foreach (var user in x.items)
                {
                    Program program = new Program();
                    program.GetInfo(responseLogin.session_id, user);
                    Thread.Sleep(700);
                    Console.WriteLine($"{DateTime.Now.ToString()}\tFind {people.Count} peoples total");
                }

                req.Raw(xNet.HttpMethod.PUT, "https://pradn.net/v4/session");

            }
            req.Raw(xNet.HttpMethod.PUT, "https://pradn.net/v4/session");
        }*/
            Console.ReadLine();
        }

        public  void GetInfo(string session_id, SearchProfiles.Item user)
        {
            try
            {
                HttpRequest req = new HttpRequest();
                req["x-api-key"] = "M0iGVpi2C4MZGdYSGYQDx5Oy3pts6SJa";
                req[HttpHeader.Accept] = "application/json";
                req[HttpHeader.AcceptCharset] = "utf-8";
                req[HttpHeader.AcceptLanguage] = "en";
                req.UserAgent = "PlanetRomeo/1000000536 Android/5.1.1 (samsung; SM-G930L)";
                req["x-session-id"] = session_id;
                Profile.UserProfile userProfile = JsonConvert.DeserializeObject<Profile.UserProfile>(req.Get($"https://pradn.net/v4/profiles/{user.id}/full?expand=partner%2Cshared_album_grant_status%2Calbums%2Cbed_and_breakfast").ToString());
                lock (this)
                {
                    Program.people.Add(userProfile);

                }
                if (!Directory.Exists($"Parser\\{userProfile.location.country}"))
                    Directory.CreateDirectory($"Parser\\{userProfile.location.country}");
                if (!Directory.Exists($"Parser\\{userProfile.location.country}\\{userProfile.location.name}"))
                    Directory.CreateDirectory($"Parser\\{userProfile.location.country}\\{userProfile.location.name}");
                if (!Directory.Exists($"Parser\\{userProfile.location.country}\\{userProfile.location.name}\\{userProfile.id}"))
                    Directory.CreateDirectory($"Parser\\{userProfile.location.country}\\{userProfile.location.name}\\{userProfile.id}");
                if (!Directory.Exists($"Parser\\{userProfile.location.country}\\{userProfile.location.name}\\{userProfile.id}\\Photos"))
                    Directory.CreateDirectory($"Parser\\{userProfile.location.country}\\{userProfile.location.name}\\{userProfile.id}\\Photos");
                File.WriteAllText($"Parser\\{userProfile.location.country}\\{userProfile.location.name}\\{userProfile.id}\\UserData.json", JsonConvert.SerializeObject(userProfile) + "\r\n");
                File.WriteAllText($"Parser\\{userProfile.location.country}\\{userProfile.location.name}\\{userProfile.id}\\HeadLine.txt", userProfile.headline + "\r\n");
                File.AppendAllText($"Parser\\UserData.json", JsonConvert.SerializeObject(userProfile) + "\r\n");
                File.AppendAllText($"Parser\\HeadLine.txt", userProfile.headline + "\r\n"); File.AppendAllText($"Parser\\UserData.json", JsonConvert.SerializeObject(userProfile) + "\r\n");
                File.AppendAllText($"Parser\\{ userProfile.location.country}\\HeadLine.txt", userProfile.headline + "\r\n");
                
                try
                {
                    req.Raw(xNet.HttpMethod.PUT, $"https://pradn.net/v4/profiles/{user.id}/footprint", new StringContent("{\"footprint_id\":\"205\"}") { ContentType = "application/json" });
                    Messages.SendMesage mess = new Messages.SendMesage(user.id, $"Hi, {user.name}! If you really looking for gay, Join to world's biggest gay club - https://bigosx.com club! A lot of gays from {user.location.name}. Membership is free!");
                    Console.WriteLine("\t\t" + req.Post("https://pradn.net/v4/messages", JsonConvert.SerializeObject(mess), "application/json; charset=utf-8"));
                    Thread.Sleep(2000);
                    foreach (var album in userProfile.albums)
                    {
                        if (album.items != null)
                        {
                            foreach (var i in album.items)
                            {
                                try
                                {
                                    HttpRequest req1 = new HttpRequest();
                                    req1.Get($"https://pradn.net/img/usr/original/1x1/{i.url_token}.jpg").ToFile($"Parser\\{userProfile.location.country}\\{userProfile.location.name}\\{userProfile.id}\\Photos\\{i.url_token}.jpg");
                                    req1.Get($"https://pradn.net/img/usr/original/1x1/{i.url_token}.jpg").ToFile($"Parser\\Photos\\{i.url_token}.jpg");
                                    req.Get($"https://pradn.net/v4/%2Freactions%2Fpictures%2Fbasic%2F/summary?element_id={i.id}&value=LIKE");
                                    ProfileWork.SendLike sendLike = new ProfileWork.SendLike("LIKE", i.id);
                                    //req.Post($"https://pradn.net/v4/%2Freactions%2Fpictures%2Fbasic%2F?element_id={i.id}", JsonConvert.SerializeObject(sendLike), "application/json; charset=utf-8");

                                   
                                    break;
                                }
                                catch { }
                                finally { }
                            }
                        }
                    }
                }
                catch { }
            }
            catch { }

        }
    }
    public class Responsed
    {
        public string status { get; set; }
        public string status_url { get; set; }
    }
}
/*
 x-api-key: M0iGVpi2C4MZGdYSGYQDx5Oy3pts6SJa
accept: application/json
accept-charset: utf-8
user-agent: PlanetRomeo/1000000536 Android/5.1.1 (samsung; SM-G930L)
accept-language: ru
content-type: application/json; charset=UTF-8
content-length: 293
accept-encoding: gzip

{"birthdate":"1998-04-06T13:09:35+0300","email":"all.monk@bk.ru","language":"ru","location":{"name":"","lat":30.79186133751967,"long":-83.78988683223723,"region":"","address":{"address":"","state":0,"time":0,"retry":0},"sensor":false},"name":"EvgenyBent","password":"Myaso_121","type":"ROMEO"}
     
     
     */
     /*
      
     
            //HttpRequest req = new HttpRequest();
            //string Pattern = "(?<=CSRF_TOKEN\\ =\\ \").*(?=\")";
            //req.UserAgent = Http.FirefoxUserAgent();
            //req[HttpHeader.Accept] = @"application/json, text/javascript, *//*; q=0.01";
            //req[HttpHeader.AcceptLanguage] = "ru-RU,ru;q=0.8,en-US;q=0.5,en;q=0.3";
            //req["X-Requested-With"] = "XMLHttpRequest";
            //req["TE"] = "Trailers";
           
            //string Cook = "wgnps_shop_csrftoken=vsrSAJCY2HjrHG0JIYE1BbzFyHtRcJru; wgnps_shop_language=ru; wgnps_shop_sessionid=ai3bgx2ojc4zsjp1tbvaugtkrhaf8rol; wgnps_shop_auth_sso_attempt_immediate=null; wgnps_shop_jwt=eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VybmFtZSI6IkFsbF9Nb25rIiwibGFuZ3VhZ2UiOiJydSIsImV4cCI6MTU4NzAyNDM0NCwiaXNzIjoidXJuOndhcmdhbWluZzpwc3MiLCJjb3VudHJ5IjoiUlUiLCJzcGFfaWQiOjE2NDUzMDM0fQ.N39MZ_RWY706aHQ3Ee9UX9OqpkfF7sUo9j5aAypUT6M; _ga=GA1.2-2.951540409.1582099536; _gid=GA1.2-2.1136543565.1586937946; cm.internal.bs_id=260ab477-1ac6-4578-2397-f05366a24f66; wguid=b0f9eab8-da52-4cb3-8447-47daf48601c4; tspaid=i2tXJNyu0C4CGnf-jSskgOBnpLvnylYSVRHv7qoDV6h4sg1A6izaQpC104fXYkzcj-akoi7LDbrmt79df-AX; wgn_realm=ru; cm.internal.spa_id=16453034; cm.internal.realm=ru; wgnp_csrftoken=rfYzCJawSQ1F1Vhl4xghy4X218tMkiwF; _gcl_au=1.1.1211609355.1582099536; _ga=GA1.1.951540409.1582099536; _ga_X9MTRN5LNY=GS1.1.1586937945.10.1.1586940303.0; _ym_uid=1582099541958647411; _ym_d=1582099541; _fbp=fb.1.1582099542205.1692131054; _ga=GA1.3.951540409.1582099536; csrftoken=bCP8ayCn216Ds1mpUUdYPJuKmtsPw0Q7; tmr_reqNum=6; tmr_lvid=aeb7b98cdea53c7de722e73a32ec03d3; tmr_lvidTS=1582718661020; STIDREFERRAL=SIDrDiu-u_8wW_GIuYL6T0wK1Uk7KaBIy3fPMRQTNViONCFZTDL9nEWC3ZFT4V8XdUm_7TXtyxTfnYhQKeAWnZpZz3WnWNMa0c1yxAynFCrVUu-A9Hw-S1K5TSmYFbktLBJTQnmSz77TuyCoPaMePRY6Zoz; enctid=c21mjq7vvomx; teclient=1583325240308314097; wgnp_language=ru; wgn_realm=ru; wgn_geowidget_popup=true; wgni_use_browser_history_update=gUsxMwA1ctZVtC4jyKpdIKkxZWogLOXS; wgn_account_is_authenticated_expiration=session; wgn_account_is_authenticated=yes; django_language=ru; _wg_commerce_shop_ga_client_id=951540409.1582099536; wgnp_sessionid=eeio0pjr1wd0d4glfhikvbdytz23q3vk; wgnp_session_security_token=78e82ca5-a1c4-4608-b5ba-979cafd3d163; authentication_confirmation_expires_at=1586103902; _ym_isad=2; _ym_visorc_22360549=w; _ym_wasSynced=%7B%22time%22%3A1586938495636%2C%22params%22%3A%7B%22eu%22%3A0%7D%2C%22bkParams%22%3A%7B%7D%7D";
            //CookieDictionary keyValuePairs = new CookieDictionary();
            //string[] Cook1 = Cook.Split(';');
            //foreach (var item in Cook1)
            //{
            //    var x = item.Replace(" ", "").Split('=');
            //    try
            //    {
            //        keyValuePairs.Add(x[0], x[1]);
            //    }
            //    catch { }
            //}
            //req.Cookies = keyValuePairs;
            //req.Referer = "https://ru.wargaming.net/";
            //string page = req.Get("https://ru.wargaming.net/shop/redeem/").ToString();
            //string Token = Regex.Match(page, Pattern).Value;
            //string Body = $"bonus_code=sdgsdgsdg&csrfmiddlewaretoken={Token}";
            //string GetCode = req.Post("https://ru.wargaming.net/shop/redeem/", Body, "application/x-www-form-urlencoded; charset=UTF-8").ToString();
            //var Code = JsonConvert.DeserializeObject<Responsed>(GetCode);
           
            //Console.WriteLine(req.Get("https://ru.wargaming.net" + Code.status_url).ToString());
     
     
     */
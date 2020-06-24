using xNet;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace PlanetRomeo.AntiCaptcha
{
    public class AntiCaptcha
    {
        public class GetResultQuery
        {
            public string clientKey { get; set; }
            public string taskId { get; set; }
        }
        public class Cookies
        {
            public string CGIC { get; set; }
            public string P_JAR { get; set; }
            public string NID { get; set; }
        }

        public class Solution
        {
            public string gRecaptchaResponse { get; set; }
            public Cookies cookies { get; set; }
        }

        public class GetResultResponse
        {
            public int errorId { get; set; }
            public string status { get; set; }
            public Solution solution { get; set; }
            public string cost { get; set; }
            public string ip { get; set; }
            public int createTime { get; set; }
            public int endTime { get; set; }
            public int solveCount { get; set; }
        }



        public class Task
        {
            public string cookies { get; set; }
            public string type { get; set; }
            public string websiteURL { get; set; }
            public string websiteKey { get; set; }
        }

        public class StartTask
        {
            public string clientKey { get; set; }
            public int softId { get; set; }
            public Task task { get; set; }
        }

        public string GetToken(string site, string siteKey)
        {
            HttpRequest request = new HttpRequest();
            StartTask task = new StartTask();
            task.clientKey = "";
            task.softId = 19;
            task.task = new Task();
            task.task.websiteURL = site;
            task.task.websiteKey = siteKey;
            return null;
        }
    }
}

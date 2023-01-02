using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks; 
using Newtonsoft.Json.Linq;
u

namespace PMGIndexer
{

    class Program
    {
        static void Main(string[] args)
        {
           // Initialize the HTTP client
            var httpClient = new HttpClient();

            // Initialize the data indexer
            var dataIndexer = new DataIndexer(httpClient);

            // Index the endpoints
            var endpoints = new Dictionary<string,type>
            {
               "https://api.pmg.org.za/bill/",
                "https://api.pmg.org.za/briefing/", 
                "https://api.pmg.org.za/call-for-comment/",
                "https://api.pmg.org.za/committee/",
                "https://api.pmg.org.za/committee-meeting/", 
                "https://api.pmg.org.za/committee-question/", 
                "https://api.pmg.org.za/daily-schedule/", 
                "https://api.pmg.org.za/gazette/", 
                "https://api.pmg.org.za/hansard/",
                "https://api.pmg.org.za/member/", 
                "https://api.pmg.org.za/minister/",
                "https://api.pmg.org.za/policy-document/", 
                "https://api.pmg.org.za/question_reply/",
                "https://api.pmg.org.za/tabled-committee-report/",
                "https://api.pmg.org.za/committee-meeting-attendance/",
                "https://api.pmg.org.za/post/"
            };

             dataIndexer.IndexEndpoints(endpoints);
        }
    }
}

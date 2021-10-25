using System;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace eveonlinetool
{
    class Program
    {
        //static void
        static void Main(string[] args)
        {
            string appName = "eve online tool";
            string appVersion = "141.5.0";
            string appAuthor = "vulcan";
            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);

            Console.WriteLine("i fixed it!");
            Console.WriteLine(" "); //line break
            var client = new HttpClient();
            var types=client.GetStringAsync("https://market.fuzzwork.co.uk/aggregates/?region=10000002&types=34,35,36,37,38,39,40").Result;

            //add time (convert to eve adding 3 hours
            var date01 = new DateTime(2021, 10, 25, 18, 32, 4); //time i set .... military time
            Console.WriteLine(date01); //"i set this one"{0} //why wont this work with string
            Console.WriteLine(" ");

            //datetime properties
            var date02 =DateTime.Now;
            var date03 =DateTime.UtcNow;
            var date04 =DateTime.Today;

            Console.WriteLine($"hi  { date02}");
            
            Console.WriteLine($"plus 4 with utc  {date03}");
            Console.WriteLine($"date no time  {date04}");

            //eve time calculation
            var eveTime = date02.AddHours(4);
            Console.WriteLine($"current eve time is {eveTime}");

        }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Buy
    {
        public string weightedAverage { get; set; }
        public string max { get; set; }
        public string min { get; set; }
        public string stddev { get; set; }
        public string median { get; set; }
        public string volume { get; set; }
        public string orderCount { get; set; }
        public string percentile { get; set; }
    }

    public class Sell
    {
        public string weightedAverage { get; set; }
        public string max { get; set; }
        public string min { get; set; }
        public string stddev { get; set; }
        public string median { get; set; }
        public string volume { get; set; }
        public string orderCount { get; set; }
        public string percentile { get; set; }
    }

    public class _34
    {
        public Buy buy { get; set; }
        public Sell sell { get; set; }
    }

    public class _35
    {
        public Buy buy { get; set; }
        public Sell sell { get; set; }
    }

    public class _36
    {
        public Buy buy { get; set; }
        public Sell sell { get; set; }
    }

    public class _37
    {
        public Buy buy { get; set; }
        public Sell sell { get; set; }
    }

    public class _38
    {
        public Buy buy { get; set; }
        public Sell sell { get; set; }
    }

    public class _39
    {
        public Buy buy { get; set; }
        public Sell sell { get; set; }
    }

    public class _40
    {
        public Buy buy { get; set; }
        public Sell sell { get; set; }
    }

    public class Root
    {
        public _34 _34 { get; set; }
        public _35 _35 { get; set; }
        public _36 _36 { get; set; }
        public _37 _37 { get; set; }
        public _38 _38 { get; set; }
        public _39 _39 { get; set; }
        public _40 _40 { get; set; }
    }


}

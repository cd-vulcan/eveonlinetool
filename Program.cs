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
            string types = client.GetStringAsync("https://market.fuzzwork.co.uk/aggregates/?region=10000002&types=34,35,36,37,38,39,40").Result;
            var result = JsonSerializer.Deserialize<fuzzworkEx>(types); ;
            var allThings = result.types; //???????? need another class?


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


}

﻿using System;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace eveonlinetool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("i fixed it!");
            var client = new HttpClient();
            var types=client.GetStringAsync("https://market.fuzzwork.co.uk/aggregates/?region=10000002&types=34,35,36,37,38,39,40").Result;
        }
    }
}

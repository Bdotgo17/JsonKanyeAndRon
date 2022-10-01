using System;
using System.Net.Http;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace JsonExerciseOneKanyeAndRon
{
    class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.KanyeQuote();

            QuoteGenerator.RonQuote();
        }
    }
}


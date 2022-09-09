

using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;


var client = new HttpClient();

var kanyeURL = "https://api.kanye.rest/";

var ronclient = new HttpClient();

var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

for (int i = 0; i < 5; i++)
{
    var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

    var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

    var ronResponse = ronclient.GetStringAsync(ronURL).Result;

    var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Replace("\"", "").Trim();


    Console.WriteLine($"Kayne: {kanyeQuote}");
    
    Console.WriteLine($"Ron: {ronQuote}\n");
}



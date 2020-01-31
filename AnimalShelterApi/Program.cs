using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AnimalShelterApi.Solution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

// using System;
// using System.Threading.Tasks;
// using RestSharp;
// using Newtonsoft.Json;
// using Newtonsoft.Json.Linq;
// using System.Collections.Generic;

// namespace ApiTest
// {
//   class Program
//   {
//     static void Main()
//     {
//       var apiCallTask = ApiHelper.ApiCall("laz2KMxYUnImJoteocxkfm8aaTqwiqctaH9Wkuis");
//       var result = apiCallTask.Result;

//       JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
//       List<Article> articleList = JsonConvert.DeserializeObject<List<Article>>(jsonResponse["results"].ToString());

//       foreach (Article article in articleList)
//       {
//         Console.WriteLine($"State: {article.Section}");
//         Console.WriteLine($"Park: {article.Title}");
        // Console.WriteLine($"Abstract: {article.Abstract}");
        // Console.WriteLine($"Url: {article.Url}");
        // Console.WriteLine($"Byline: {article.Byline}");
//       }
//     }
//   }

//   class ApiHelper
//   {
//     public static async Task<string> ApiCall(string apiKey)
//     {
//       RestClient client = new RestClient("https://www.nps.gov/subjects/digital/index.htm");
//       RestRequest request = new RestRequest($"home.json?api-key={apiKey}", Method.GET);
//       var response = await client.ExecuteTaskAsync(request);
//       return response.Content;
//     }
//   }
// }


// laz2KMxYUnImJoteocxkfm8aaTqwiqctaH9Wkuis

// https://localhost:5000/swagger/v1/swagger.json
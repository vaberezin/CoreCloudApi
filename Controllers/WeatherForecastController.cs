using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using System.IO;
using System.Collections.Specialized;
using System.Net.Http;
using System.Text.Json;
using System.Reflection.Metadata;
using System.Reflection;
using Newtonsoft.Json;
using CloudApiService.util;


namespace CloudApiService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        WeatherForecast tverWeather;
        
        [HttpGet]
        
        // GET: api/Weather
        public OkResult Get()
        {
            string teststring;
            List<string> list = new List<string>();

            using (var client = new HttpClient())
            {
                double lat = 56.859625;
                double lon = 35.911851;
                string lang = "ru_RU";
                int limit = 2;
                bool hours = false;
                bool extra = false;
                string apiValue = "8f45aa9d-04a5-4af7-a9d1-e9fb8dc7df3e";
                string apiKey = $"X-Yandex-API-Key";
                NameValueCollection apiKeyNVCol = new NameValueCollection();
                apiKeyNVCol.Add(apiKey, apiValue);


                string responsePath = "https://api.weather.yandex.ru/v2/forecast?" + $"lat={lat}&lon={lon}&lang={lang}&limit={limit}&hours={hours.ToString()}&extra={extra.ToString()}";
                //httprequestmessage mes = new httprequestmessage();
                

                //var response = client.GetAsync().;
                HttpWebRequest httpWebRequest = HttpWebRequest.CreateHttp(responsePath);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = "application/json";
                //httpWebRequest.Headers.Add(apiKeyNVCol);
                httpWebRequest.Headers.Add(apiKey, apiValue);
                
                
                
                Task<WebResponse> response = httpWebRequest.GetResponseAsync();
                string test = response.Result.ContentType;
                var stream = response.Result.GetResponseStream();
                
                StreamReader streamReader = new StreamReader(stream);
                teststring = streamReader.ReadToEnd();
                
                


                string[] strmass = new string[99];

                //var myObject = JsonSerializer.DeserializeAsync<MyWeather>(stream, null, new System.Threading.CancellationToken());
                tverWeather = JsonConvert.DeserializeObject<WeatherForecast>(teststring);

                
                
                
                //using (FileStream fs2 = new FileStream($@"{path}\note.txt", FileMode.OpenOrCreate))  {
                //    
                //    DirectoryInfo dirInfo = new DirectoryInfo(path);
                //        if (!dirInfo.Exists)
                //        {
                //            dirInfo.Create();
                //        }
                //    fs2.WriteAsync(buffer,0, buffer.Length);
                //}                
            }

            tverWeather.

            return Ok();
            
        }
    }
}

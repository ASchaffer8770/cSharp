using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Weather
{
    public class OpenWeatherMapProxy
    {
        public async static Root GetWeather(double lat, double lon)
        {
            var http = new HttpClient();
            var response = await http.GetAsync("https://api.weatherapi.com/v1/current.json?key=4b40e4471568477e9f3191044230501&q=47.6588,-117.4260&aqi=no");
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(Root));
        }
    }

    [DataContract]
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Condition
    {
        [DataMember]
        public string text { get; set; }
        [DataMember]
        public string icon { get; set; }
        [DataMember]
        public int code { get; set; }
    }

    [DataContract]
    public class Current
    {
        [DataMember]
        public int last_updated_epoch { get; set; }
        [DataMember]
        public string last_updated { get; set; }
        [DataMember]
        public double temp_c { get; set; }
        [DataMember]
        public double temp_f { get; set; }
        [DataMember]
        public int is_day { get; set; }
        [DataMember]
        public Condition condition { get; set; }
        [DataMember]
        public double wind_mph { get; set; }
        [DataMember]
        public double wind_kph { get; set; }
        [DataMember]
        public int wind_degree { get; set; }
        [DataMember]
        public string wind_dir { get; set; }
        [DataMember]
        public double pressure_mb { get; set; }
        [DataMember]
        public double pressure_in { get; set; }
        [DataMember]
        public double precip_mm { get; set; }
        [DataMember]
        public double precip_in { get; set; }
        [DataMember]
        public int humidity { get; set; }
        [DataMember]
        public int cloud { get; set; }
        [DataMember]
        public double feelslike_c { get; set; }
        [DataMember]
        public double feelslike_f { get; set; }
        [DataMember]
        public double vis_km { get; set; }
        [DataMember]
        public double vis_miles { get; set; }
        [DataMember]
        public double uv { get; set; }
        [DataMember]
        public double gust_mph { get; set; }
        [DataMember]
        public double gust_kph { get; set; }
    }

    [DataContract]
    public class Location
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string region { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public double lat { get; set; }
        [DataMember]
        public double lon { get; set; }
        [DataMember]
        public string tz_id { get; set; }
        [DataMember]
        public int localtime_epoch { get; set; }
        [DataMember]
        public string localtime { get; set; }
    }

    [DataContract]
    public class Root
    {
        [DataMember]
        public Location location { get; set; }
        [DataMember]
        public Current current { get; set; }
    }


}
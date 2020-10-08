using System;
using System.Collections.Generic;

namespace CloudApiService
{
    public class WeatherForecast
    {
       // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Tzinfo    {
        public string name { get; set; } 
        public string abbr { get; set; } 
        public int offset { get; set; } 
        public bool dst { get; set; } 
    }

    public class Info    {
        public bool f { get; set; } 
        public bool n { get; set; } 
        public bool nr { get; set; } 
        public bool ns { get; set; } 
        public bool nsr { get; set; } 
        public bool p { get; set; } 
        public double lat { get; set; } 
        public double lon { get; set; } 
        public int geoid { get; set; } 
        public string slug { get; set; } 
        public int zoom { get; set; } 
        public Tzinfo tzinfo { get; set; } 
        public int def_pressure_mm { get; set; } 
        public int def_pressure_pa { get; set; } 
        public bool _h { get; set; } 
        public string url { get; set; } 
    }

    public class AccumPrec    {
        public double one { get; set; } 
        public double three { get; set; } 
        public double seven { get; set; } 
    }

    public class Fact    {
        public int temp { get; set; } 
        public int feels_like { get; set; } 
        public string icon { get; set; } 
        public string condition { get; set; } 
        public double wind_speed { get; set; } 
        public double wind_gust { get; set; } 
        public string wind_dir { get; set; } 
        public int pressure_mm { get; set; } 
        public int pressure_pa { get; set; } 
        public int humidity { get; set; } 
        public int uv_index { get; set; } 
        public int soil_temp { get; set; } 
        public double soil_moisture { get; set; } 
        public string daytime { get; set; } 
        public bool polar { get; set; } 
        public string season { get; set; } 
        public int obs_time { get; set; } 
        public AccumPrec accum_prec { get; set; } 
        public string source { get; set; } 
    }

    public class Night    {
        public string _source { get; set; } 
        public int temp_min { get; set; } 
        public int temp_max { get; set; } 
        public int temp_avg { get; set; } 
        public int feels_like { get; set; } 
        public string icon { get; set; } 
        public string condition { get; set; } 
        public string daytime { get; set; } 
        public bool polar { get; set; } 
        public double wind_speed { get; set; } 
        public double wind_gust { get; set; } 
        public string wind_dir { get; set; } 
        public int pressure_mm { get; set; } 
        public int pressure_pa { get; set; } 
        public int humidity { get; set; } 
        public int uv_index { get; set; } 
        public int soil_temp { get; set; } 
        public double soil_moisture { get; set; } 
        public int prec_mm { get; set; } 
        public int prec_period { get; set; } 
        public int prec_prob { get; set; } 
    }

    public class Morning    {
        public string _source { get; set; } 
        public int temp_min { get; set; } 
        public int temp_max { get; set; } 
        public int temp_avg { get; set; } 
        public int feels_like { get; set; } 
        public string icon { get; set; } 
        public string condition { get; set; } 
        public string daytime { get; set; } 
        public bool polar { get; set; } 
        public double wind_speed { get; set; } 
        public double wind_gust { get; set; } 
        public string wind_dir { get; set; } 
        public int pressure_mm { get; set; } 
        public int pressure_pa { get; set; } 
        public int humidity { get; set; } 
        public int uv_index { get; set; } 
        public int soil_temp { get; set; } 
        public double soil_moisture { get; set; } 
        public int prec_mm { get; set; } 
        public int prec_period { get; set; } 
        public int prec_prob { get; set; } 
    }

    public class Day    {
        public string _source { get; set; } 
        public int temp_min { get; set; } 
        public int temp_max { get; set; } 
        public int temp_avg { get; set; } 
        public int feels_like { get; set; } 
        public string icon { get; set; } 
        public string condition { get; set; } 
        public string daytime { get; set; } 
        public bool polar { get; set; } 
        public double wind_speed { get; set; } 
        public double wind_gust { get; set; } 
        public string wind_dir { get; set; } 
        public int pressure_mm { get; set; } 
        public int pressure_pa { get; set; } 
        public int humidity { get; set; } 
        public int uv_index { get; set; } 
        public int soil_temp { get; set; } 
        public double soil_moisture { get; set; } 
        public double prec_mm { get; set; } 
        public int prec_period { get; set; } 
        public int prec_prob { get; set; } 
    }

    public class Evening    {
        public string _source { get; set; } 
        public int temp_min { get; set; } 
        public int temp_max { get; set; } 
        public int temp_avg { get; set; } 
        public int feels_like { get; set; } 
        public string icon { get; set; } 
        public string condition { get; set; } 
        public string daytime { get; set; } 
        public bool polar { get; set; } 
        public double wind_speed { get; set; } 
        public double wind_gust { get; set; } 
        public string wind_dir { get; set; } 
        public int pressure_mm { get; set; } 
        public int pressure_pa { get; set; } 
        public int humidity { get; set; } 
        public int uv_index { get; set; } 
        public int soil_temp { get; set; } 
        public double soil_moisture { get; set; } 
        public double prec_mm { get; set; } 
        public int prec_period { get; set; } 
        public int prec_prob { get; set; } 
    }

    public class DayShort    {
        public string _source { get; set; } 
        public int temp { get; set; } 
        public int temp_min { get; set; } 
        public int feels_like { get; set; } 
        public string icon { get; set; } 
        public string condition { get; set; } 
        public double wind_speed { get; set; } 
        public double wind_gust { get; set; } 
        public string wind_dir { get; set; } 
        public int pressure_mm { get; set; } 
        public int pressure_pa { get; set; } 
        public int humidity { get; set; } 
        public int uv_index { get; set; } 
        public int soil_temp { get; set; } 
        public double soil_moisture { get; set; } 
        public double prec_mm { get; set; } 
        public int prec_prob { get; set; } 
    }

    public class NightShort    {
        public int temp { get; set; } 
        public int feels_like { get; set; } 
        public string icon { get; set; } 
        public string condition { get; set; } 
        public double wind_speed { get; set; } 
        public double wind_gust { get; set; } 
        public string wind_dir { get; set; } 
        public int pressure_mm { get; set; } 
        public int pressure_pa { get; set; } 
        public int humidity { get; set; } 
        public int uv_index { get; set; } 
        public int soil_temp { get; set; } 
        public double soil_moisture { get; set; } 
        public int prec_mm { get; set; } 
        public int prec_prob { get; set; } 
    }

    public class Parts    {
        public Night night { get; set; } 
        public Morning morning { get; set; } 
        public Day day { get; set; } 
        public Evening evening { get; set; } 
        public DayShort day_short { get; set; } 
        public NightShort night_short { get; set; } 
    }

    public class Forecast    {
        public string date { get; set; } 
        public int date_ts { get; set; } 
        public int week { get; set; } 
        public string sunrise { get; set; } 
        public string sunset { get; set; } 
        public string rise_begin { get; set; } 
        public string set_end { get; set; } 
        public int moon_code { get; set; } 
        public string moon_text { get; set; } 
        public Parts parts { get; set; } 
    }

    public class Root    {
        public int now { get; set; } 
        public DateTime now_dt { get; set; } 
        public Info info { get; set; } 
        public Fact fact { get; set; } 
        public List<Forecast> forecasts { get; set; } 
    }


    }
}

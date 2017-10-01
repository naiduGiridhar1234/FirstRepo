using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Location.Models
{
  
    public class Timezone
    {
        public string id { get; set; }
       
        public string currency_alpha_code { get; set; }
     
    }

   
    public class Data
    {
        public string ip { get; set; }
        public string city { get; set; }
        public string postal { get; set; }
        public string state { get; set; }
        public string state_code { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string location { get; set; }
        public Timezone timezone { get; set; }
     
    }

    public class RootObject
    {
       
        public Data data { get; set; }
    }
   
}





//public class Meta
//{
//    public string code { get; set; }
//    public string execution_time { get; set; }
//}

//public class Timezone
//{
//    public string id { get; set; }
//    public string location { get; set; }
//    public string country_code { get; set; }
//    public string country_name { get; set; }
//    public string iso3166_1_alpha_2 { get; set; }
//    public string iso3166_1_alpha_3 { get; set; }
//    public string un_m49_code { get; set; }
//    public string itu { get; set; }
//    public string marc { get; set; }
//    public string wmo { get; set; }
//    public string ds { get; set; }
//    public string phone_prefix { get; set; }
//    public string fifa { get; set; }
//    public string fips { get; set; }
//    public string gual { get; set; }
//    public string ioc { get; set; }
//    public string currency_alpha_code { get; set; }
//    public string currency_country_name { get; set; }
//    public string currency_minor_unit { get; set; }
//    public string currency_name { get; set; }
//    public string currency_code { get; set; }
//    public string independent { get; set; }
//    public string capital { get; set; }
//    public string continent { get; set; }
//    public string tld { get; set; }
//    public string languages { get; set; }
//    public string geoname_id { get; set; }
//    public string edgar { get; set; }
//}

//public class Datetime
//{
//    public string date { get; set; }
//    public string date_time { get; set; }
//    public string date_time_txt { get; set; }
//    public string date_time_wti { get; set; }
//    public string date_time_ymd { get; set; }
//    public string time { get; set; }
//    public string month { get; set; }
//    public string month_wilz { get; set; }
//    public string month_abbr { get; set; }
//    public string month_full { get; set; }
//    public string month_days { get; set; }
//    public string day { get; set; }
//    public string day_wilz { get; set; }
//    public string day_abbr { get; set; }
//    public string day_full { get; set; }
//    public string year { get; set; }
//    public string year_abbr { get; set; }
//    public string hour_12_wolz { get; set; }
//    public string hour_12_wilz { get; set; }
//    public string hour_24_wolz { get; set; }
//    public string hour_24_wilz { get; set; }
//    public string hour_am_pm { get; set; }
//    public string minutes { get; set; }
//    public string seconds { get; set; }
//    public string week { get; set; }
//    public string offset_seconds { get; set; }
//    public string offset_minutes { get; set; }
//    public string offset_hours { get; set; }
//    public string offset_gmt { get; set; }
//    public string offset_tzid { get; set; }
//    public string offset_tzab { get; set; }
//    public string dst { get; set; }
//    public string dst_observes { get; set; }
//    public string timeday_spe { get; set; }
//    public string timeday_gen { get; set; }
//}

//public class Data
//{
//    public string ip { get; set; }
//    public string city { get; set; }
//    public string postal { get; set; }
//    public string state { get; set; }
//    public string state_code { get; set; }
//    public string country { get; set; }
//    public string country_code { get; set; }
//    public string location { get; set; }
//    public Timezone timezone { get; set; }
//    public Datetime datetime { get; set; }
//}

//public class RootObject
//{
//    public Meta meta { get; set; }
//    public Data data { get; set; }
//}
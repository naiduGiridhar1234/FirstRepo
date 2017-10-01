using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Location.Models;
using System.Text;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace Location.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var url = "https://timezoneapi.io/api/ip/";
        

           // var url = "https://timezoneapi.io/api/ip/?ip=5.9.31.87";

            using (var client = new System.Net.WebClient())




            {
              //  var resp = client.DownloadData(url);
              //  byte[] by = resp;
              //  string str = System.Text.Encoding.ASCII.GetString(resp);

                var response = client.DownloadData(url);
                var b = 0;
                var abc = 1234;
                var response1 = Encoding.Default.GetString(response);
                JavaScriptSerializer oJS = new JavaScriptSerializer();
                //RootObject oRootObject = new RootObject();
                var oRootObject = oJS.Deserialize<RootObject>(response1);
                var _country = oRootObject.data.country;
                var _currency = oRootObject.data.timezone.currency_alpha_code;
                var ip = oRootObject.data.ip;
            
                return View(oRootObject);
            }
        }

        
    }
}
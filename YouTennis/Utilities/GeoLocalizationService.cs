using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using YouTennis.Model;

namespace YouTennis.Utilities
{
    public class GeoLocalizationService
    {
        private const string URL = "http://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=true_or_false";
        private const string DATA = @"{""object"":{""name"":""Name""}}";



        public static EntityAddress CreateAddress(string address)
        {
            var requestUri = string.Format(URL, Uri.EscapeDataString(address));
            EntityAddress a = new EntityAddress();

            try
            {
                var request = WebRequest.Create(requestUri);
                var response = request.GetResponse();
                var xdoc = XDocument.Load(response.GetResponseStream());

                var result = xdoc.Element("GeocodeResponse").Element("result");

                var locationElement = result.Element("geometry").Element("location");

                var address_components = result.Elements("address_component");
                foreach(var el in address_components)
                {
                    var typeEl = el.Element("type");
                    switch (typeEl.Value)
                    {
                        case "stree_number":
                            break;
                        case "route":
                            break;
                        case "locality":
                            break;
                        case "administrative_area_level_3":
                            break;
                        case "administrative_area_level_2":
                            break;
                        case "administrative_area_level_1":
                            break;
                        case "country":
                            break;
                        case "postal_code":
                            break;
                    }
                }
                
                var lat = locationElement.Element("lat");
                var lng = locationElement.Element("lng");
                a.Coordinate.Latitude = double.Parse(lat.Value);
                a.Coordinate.Longitude = double.Parse(lng.Value);
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("-----------------");
                Console.Out.WriteLine(e.Message);
            }
            return a;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WpApp.Core.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WpApp.Core.Services
{
    public class GooglePlaceSearchApi
    {
        private const string ApiKey = "AIzaSyDCEEpSZit8oF3j02yWf7QX_e0ZlWKxCkk";
        private const string AutoCompleteUriTemplate = "https://maps.googleapis.com/maps/api/place/autocomplete/json?input={0}&types=establishment&location={1}&radius=500&key={2}";
        private const string FindPlaceByIdUriTemplate = "https://maps.googleapis.com/maps/api/place/details/json?placeid={0}&key={1}";

        public async Task<List<GoogleAutoCompleteResult>> AutoComplete(string search, string locationCoordinates = "45.6272140,-122.6706040")
        {
            var url = string.Format(AutoCompleteUriTemplate,search,locationCoordinates, ApiKey);
            var results = new List<GoogleAutoCompleteResult>();
            var client = new HttpClient();

            try
            {
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                {
                    return null;
                }

                dynamic jsonObj = JsonConvert.DeserializeObject(json);
                dynamic predictions = jsonObj["predictions"];

                foreach (var prediction in predictions)
                {
                    string description = prediction["description"].Value;
                    var commaIndex = description.IndexOf(",", StringComparison.Ordinal);

                    var result = new GoogleAutoCompleteResult()
                    {
                        PlaceId = prediction["place_id"].Value,
                        Name = description.Substring(0, commaIndex),
                        Address = description.Substring(commaIndex + 2, description.Length - commaIndex - 2)
                    };
                    
                    results.Add(result);
                }

            }
            catch (Exception e)
            {
                var exception = e.InnerException;
                //Handle this error is some sort of way...
            }

            return results;
        }

        public async Task<GoogleLocation> FindPlacesById(string id)
        {
            var url = string.Format(FindPlaceByIdUriTemplate, id, ApiKey);
            var location = new GoogleLocation();
            var client = new HttpClient();

            try
            {
                var json = await client.GetStringAsync(url);

                if (string.IsNullOrWhiteSpace(json))
                {
                    return null;
                }

                dynamic jsonObj = JsonConvert.DeserializeObject(json);
                dynamic locationObj = jsonObj["result"];

                location = new GoogleLocation()
                {
                    PlaceId = id,
                    Name = locationObj["name"].Value,
                    Address = locationObj["formatted_address"].Value,
                    Icon = locationObj["icon"].Value,
                    Latitude = locationObj["geometry"]["location"]["lat"].Value,
                    Longitude = locationObj["geometry"]["location"]["lng"].Value,
                    PhoneNumber = locationObj["formatted_phone_number"]?.Value
                };


            }
            catch (Exception e)
            {
                var exception = e.InnerException;
                //Handle this error is some sort of way...
            }


            return location;
        }
    }
}

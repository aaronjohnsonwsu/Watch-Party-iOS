using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ObjCRuntime;
using WpApp.Core.Models;

namespace WpApp.Core.Services
{
    public class WatchPartyApi
    {
        private string _uri = "http://aaronjohnsonwsu-001-site1.btempurl.com/api/";

        public async void AddEvent(Event evnt)
        {
            var client = new HttpClient();

            var uri = new Uri(_uri + "events/");
            var json = JsonConvert.SerializeObject(evnt);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(uri, content);

        }

        public async Task<List<Team>> GetTeams()
        {
            var client = new HttpClient();

            try
            {
                var response = await client.GetStringAsync(_uri + "teams/");

                return JsonConvert.DeserializeObject<List<Team>>(response);
            }
            catch (Exception e)
            {
                var er = e.InnerException;
            }
            var resp = await client.GetStringAsync(_uri + "teams/");

            return JsonConvert.DeserializeObject<List<Team>>(resp);
        } 
    }
}

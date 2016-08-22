using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using WpApp.Core.Models;

namespace WpApp.Core.Services
{
    public class CollegeTeamApi
    {
        public List<Team> AutoComplete(string search)
        {
            using (var reader = new StreamReader("Data/teams.json"))
            {
                var json = reader.ReadToEnd();

                var teams = JsonConvert.DeserializeObject<List<Team>>(json);

                return teams.Where(t => t.Mascot.Contains(search)).ToList();
            }

        } 
    }
}

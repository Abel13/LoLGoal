using LoLGoal.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLGoal.API
{
    public class League_V4 : Api
    {
        public League_V4(string region) : base(region)
        {
        }

        public List<PositionDTO> GetPositions(string summonerId)
        {
            string path = "league/v4/positions/by-summoner/" + summonerId;

            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<PositionDTO>>(content);
            }
            else
            {
                return null;
            }
        }
    }
}

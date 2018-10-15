using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OPEN_AQ_Pollution.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OPEN_AQ_Pollution.Observer
{
    public class ObserverPollution
    {
        public List<ObserverModel> observerModels { get; } = new List<ObserverModel>();

        private DatabaseContext _pollutionContext;
        private string url = $"https://api.openaq.org/v1/latest";
        private readonly HttpClient client = new HttpClient();
        private async Task<IEnumerable<Pollution>> Get(string country, string city)
        {
            List<Pollution> pollutions = new List<Pollution>();
            var response = await client.GetAsync($"{url}?country={country}&city={city}");
            var responseString = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(responseString);
            var token = json["results"];
            foreach (var item in token.Children())
            {
                var pollution = JsonConvert.DeserializeObject<Pollution>(item["measurements"].First.ToString());
                pollution.City = item["city"].ToString();
                pollution.Location = item["location"].ToString();
                pollution.Country = item["country"].ToString();
                pollutions.Add(pollution);
            }
            return pollutions;
        }
        public ObserverPollution()
        {
            observerModels.Add(new ObserverModel
            {
                Country = "US",
                Cities = new List<string>()
                {
                    "Omaha-Council Bluffs",
                    "Tucson",
                    "Joplin",
                    "Detroit-Warren-Livonia",
                    "Chicago-Naperville-Joliet"
                }
            });
            observerModels.Add(new ObserverModel
            {
                Country = "CA",
                Cities = new List<string>()
                {
                    "BRITISH COLUMBIA",
                    "ONTARIO",
                    "ALBERTA",
                    "NEW BRUNSWICK",
                    "QUEBEC"
                }
            });
            _pollutionContext = new DatabaseContext();
        }

        public void Start()
        {
            var task = Task.Factory.StartNew(Observer);
        }

        private async void Observer()
        {
            while (true)
            {
                foreach (var country in observerModels)
                {
                    foreach (var city in country.Cities)
                    {
                        var result = await Get(country.Country, city);

                        foreach (var item in result)
                        {
                            if (!_pollutionContext.Pollutions.
                                Any(p => p.Country == item.Country &&
                                    p.City == item.City &&
                                    p.Location == item.Location &&
                                    p.Parameter == item.Parameter &&
                                    p.LastUpdate == item.LastUpdate))
                            {
                                _pollutionContext.Pollutions.Add(item);
                            }
                        }
                    }
                }
                await _pollutionContext.SaveChangesAsync();
                Thread.Sleep(600000);//10 min
            }
        }
    }
}

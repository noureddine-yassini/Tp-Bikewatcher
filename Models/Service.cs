using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;
using System.Net.Http;
using System.Text.Json;

namespace MvcMovie.Models
{
    public static class Service
    {
        private static readonly HttpClient client = new HttpClient();
        public static async Task<List<Station>> Station()
        {
            var ApiData = client.GetStreamAsync("https://download.data.grandlyon.com/ws/rdata/jcd_jcdecaux.jcdvelov/all.json");
            var RootObject = await JsonSerializer.DeserializeAsync<RootObject>(await ApiData);

            return RootObject.values;
        }
        public static async Task<List<StationBdx>> StationBdx()
        {
            var ApiData = client.GetStreamAsync("https://api.alexandredubois.com/vcub-backend/vcub.php");
            var RootObject = await JsonSerializer.DeserializeAsync<List<StationBdx>>(await ApiData);

            return RootObject;
        }

    }
}

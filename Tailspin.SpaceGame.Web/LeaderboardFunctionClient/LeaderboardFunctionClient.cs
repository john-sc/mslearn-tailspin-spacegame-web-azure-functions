﻿using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace TailSpin.SpaceGame.Web
{
    public class LeaderboardFunctionClient : ILeaderboardServiceClient
    {
        private string _functionUrl;

        public LeaderboardFunctionClient(string functionUrl)
        {
            this._functionUrl = functionUrl;
        }

        async public Task<LeaderboardResponse> GetLeaderboard(int page, int pageSize, string mode, string region)
        {
            using (WebClient webClient = new WebClient())
            {
               var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                    ,MaxDepth = 10
                    //,IncludeFields = true
                };
                 string json = await webClient.DownloadStringTaskAsync($"{this._functionUrl}?page={page}&pageSize={pageSize}&mode={mode}&region={region}");
                //string json = await webClient.DownloadStringTaskAsync($"{this._functionUrl}/api/LeaderboardFunction?page={page}&pageSize={pageSize}&mode={mode}&region={region}");
                return JsonSerializer.Deserialize<LeaderboardResponse>(json, options);
            }
        }
    }
}

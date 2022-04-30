using System.Text.Json;
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
                //string json0 = await webClient.DownloadStringTaskAsync($"{this._functionUrl}?page={page}&pageSize={pageSize}&mode={mode}&region={region}");
                //string json = await webClient.DownloadStringTaskAsync("https://tailspin-space-game-leaderboard-20361.azurewebsites.net/api/LeaderboardFunction?page=&pageSize=10&mode=");
                string json = "{"selectedMode":"","selectedRegion":null,"page":0,"pageSize":10,"scores":[{"score":{"profileId":"1","highScore":999999,"gameMode":"Solo","gameRegion":"Milky Way","id":"1"},"profile":{"userName":"duality","avatarUrl":"images/avatars/default.svg","achievements":["Professor","Space Race","Photon Hunter","Professor","King of the Hill","Faster than Light","Cosmologist","Cruiser","Particle Accelerator"],"id":"1"}},{"score":{"profileId":"9","highScore":999998,"gameMode":"Trio","gameRegion":"NGC 1300","id":"9"},"profile":{"userName":"banant","avatarUrl":"images/avatars/default.svg","achievements":["Atom Smasher","Cruiser","Cosmologist","Space Race","Photon Hunter","Faster than Light"],"id":"9"}},{"score":{"profileId":"12","highScore":999997,"gameMode":"Trio","gameRegion":"NGC 1300","id":"12"},"profile":{"userName":"easis","avatarUrl":"images/avatars/default.svg","achievements":["Atom Smasher","Professor","Photon Hunter","Cosmologist","Master Pilot"],"id":"12"}},{"score":{"profileId":"15","highScore":996671,"gameMode":"Duo","gameRegion":"Messier 82","id":"15"},"profile":{"userName":"moose","avatarUrl":"images/avatars/default.svg","achievements":["Faster than Light","Space Race","Cruiser","King of the Hill","Atom Smasher","Photon Hunter","Particle Accelerator","Master Pilot"],"id":"15"}},{"score":{"profileId":"10","highScore":900000,"gameMode":"Trio","gameRegion":"Milky Way","id":"10"},"profile":{"userName":"microle","avatarUrl":"images/avatars/default.svg","achievements":["Master Pilot","Particle Accelerator","Professor","Cruiser","King of the Hill","Atom Smasher","Professor","Photon Hunter","Faster than Light"],"id":"10"}},{"score":{"profileId":"16","highScore":824179,"gameMode":"Solo","gameRegion":"Pinwheel","id":"16"},"profile":{"userName":"glishell","avatarUrl":"images/avatars/default.svg","achievements":["Cosmologist"],"id":"16"}},{"score":{"profileId":"5","highScore":777666,"gameMode":"Solo","gameRegion":"Messier 82","id":"5"},"profile":{"userName":"shortitem78","avatarUrl":"images/avatars/default.svg","achievements":["Atom Smasher"],"id":"5"}},{"score":{"profileId":"20","highScore":714207,"gameMode":"Solo","gameRegion":"Milky Way","id":"20"},"profile":{"userName":"vivagran","avatarUrl":"images/avatars/default.svg","achievements":["Photon Hunter","Space Race","King of the Hill"],"id":"20"}},{"score":{"profileId":"4","highScore":672918,"gameMode":"Solo","gameRegion":"Milky Way","id":"4"},"profile":{"userName":"sodapop","avatarUrl":"images/avatars/default.svg","achievements":["Photon Hunter","Cosmologist","Master Pilot","Particle Accelerator","King of the Hill","Space Race","Atom Smasher","Professor","Faster than Light"],"id":"4"}},{"score":{"profileId":"6","highScore":666555,"gameMode":"Duo","gameRegion":"Ring Nebula","id":"6"},"profile":{"userName":"captaingrocs","avatarUrl":"images/avatars/default.svg","achievements":["Cruiser","Master Pilot","Atom Smasher","King of the Hill","Faster than Light","Professor"],"id":"6"}}],"totalResults":25}";
                return JsonSerializer.Deserialize<LeaderboardResponse>(json);
            }
        }
    }
}

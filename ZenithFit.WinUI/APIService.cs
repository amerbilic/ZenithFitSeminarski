using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Http;
using ZenithFit.Model;

namespace ZenithFit.WinUI
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                var result = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

                return result;


            
        }

        public async Task<T> GetbyId<T>(object id)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>(); ;
        }

        public async Task<T> Insert<T>(object request)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object id,object update)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).PutJsonAsync(update).ReceiveJson<T>();
        }

        public async Task<T> Authenticate<T>(string username,string password)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/Authenticiraj/{username},{password}";

            return await url.GetJsonAsync<T>();
        }

        public async Task<T> CheckAdmin<T>(int RoleId)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/CheckAdmin/{RoleId}";

            return await url.GetJsonAsync<T>();
        }
    }
}

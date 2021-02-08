using Flurl.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZenithFit.Model;
namespace ZenithFit.MobileApp
{

    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static LoggedInUser LoggedUser { get; set; }

        private string _route = null;

#if DEBUG
        private string _apiUrl = "http://localhost:53194/api";
#endif
#if RELEASE
        private string _apiUrl = "https://localhost:44386/api/";
#endif

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {

            var url = $"{_apiUrl}/{_route}";
            try
            {

                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                var result = await url.GetJsonAsync<T>();

                return result;
            }

            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    
                    await Application.Current.MainPage.DisplayAlert("Error", "You are not authenticated", "OK");
                }
                throw;
            }
        }

        public async Task<T> Login<T>(string username,string password)
        {
            var url = $"{_apiUrl}/{_route}/Authenticate/{username},{password}";

            return await url.GetJsonAsync<T>();


        }

        public async Task<T> GetbyId<T>(object id)
        {

            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>(); ;
        }

        public async Task<T> Insert<T>(object request)
        {

            var url = $"{_apiUrl}/{_route}";

            return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object id, object update)
        {

            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).PutJsonAsync(update).ReceiveJson<T>();
        }

        public async Task<T> GetSimilarArticles<T>(int id)
        {
            var url = $"{_apiUrl}/{_route}/GetSimilarArticles/{id}";

            return await url.GetJsonAsync<T>();
        }
    }
}
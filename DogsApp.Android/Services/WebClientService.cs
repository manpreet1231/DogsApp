
using DogsApp.Droid.Services;
using DogsApp.Services;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(WebClientService))]
namespace DogsApp.Droid.Services
{
    class WebClientService : IWebClientService
    {
        public async Task<string> GetString(string uri)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            return null;
        }
    }
}
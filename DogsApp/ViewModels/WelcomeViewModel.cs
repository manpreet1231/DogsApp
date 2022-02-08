
using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using DogsApp.Services;
using Xamarin.Forms;

[assembly: Dependency (typeof (WebClientService))]
namespace DogsApp.ViewModels
{
    internal class WelcomeViewModel : BaseViewModel
    {
        public ICommand OpenGoogleCammand { get; }
        public ICommand OpenDogsAPICammand { get; }
        public WelcomeViewModel() 
        {
            Title = "Welcome";
            OpenGoogleCammand = new AsyncCommand(OpenGoogle);
            OpenDogsAPICammand = new AsyncCommand(OpenDogsAPI);
        }

        private async Task OpenGoogle()
        {
            await Browser.OpenAsync("https://www.google.com/");
        }

        private async Task OpenDogsAPI()
        {
            var service = DependencyService.Get<Services.IWebClientService>();
            var content = await service.GetString("https://dog.ceo/api/breeds/list/all");
        }
    }
}

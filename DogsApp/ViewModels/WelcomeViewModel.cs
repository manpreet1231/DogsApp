
using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;

namespace DogsApp.ViewModels
{
    internal class WelcomeViewModel : BaseViewModel
    {
        public ICommand OpenGoogleCammand { get; }
        public WelcomeViewModel() 
        {
            Title = "Welcome";
            OpenGoogleCammand = new AsyncCommand(OpenGoogle);
        }

        private async Task OpenGoogle()
        {
            await Browser.OpenAsync("https://www.google.com/");
        }
    }
}

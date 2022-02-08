
using MvvmHelpers;
using System.Windows.Input;

namespace DogsApp.ViewModels
{
    internal class WelcomeViewModel : BaseViewModel
    {
        public ICommand OpenGoogleCammand { get; }
        public WelcomeViewModel() 
        {
            Title = "Welcome";
        }
    }
}

//using DogsApp.Services;
//using DogsApp.Views;
using DogsApp.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DogsApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<IWebClientService>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}


using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using DogsApp.Services;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace DogsApp.ViewModels
{
    internal class WelcomeViewModel : BaseViewModel
    {
        public ICommand OpenGoogleCammand { get; }
        public ICommand OpenDogsAPICammand { get; }
        private string myStringProperty;
        public string MyStringProperty
        {
            get { return myStringProperty; }
            set
            {
                myStringProperty = value;
                OnPropertyChanged(nameof(MyStringProperty)); // Notify that there was a change on this property
            }
        }
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
            var service = DependencyService.Get<IWebClientService>();
            var content = await service.GetString("https://dog.ceo/api/breeds/list/all");
            //MyStringProperty = "affenpinscher\nafrican\nairedale\nakita\nappenzeller\naffenpinscher\nafrican\nairedale\nakita\nappenzeller\naustralian: shepherd\nbasenji\nbeagle\nbluetick\nborzoi\nbouvier\nboxer\nbrabancon\nbriard\nbuhund: norwegian\nbulldog: boston,english,french\nbullterrier: staffordshire\ncattledog: australian\nchihuahua\nchow\nclumber\ncockapoo\ncollie: border\ncoonhound\ncorgi: cardigan\ncotondetulear\ndachshund\ndalmatian\ndane: great\ndeerhound: scottish\ndhole\ndingo\ndoberman\nelkhound: norwegian\nentlebucher\neskimo\nfinnish: lapphund\nfrise: bichon\ngermanshepherd\ngreyhound: italian\ngroenendael\nhavanese\nhound: afghan,basset,blood,english,ibizan,plott,walker\nhusky\nkeeshond\nkelpie\nkomondor\nkuvasz\nlabradoodle\nlabrador\nleonberg\nlhasa\nmalamute\nmalinois\nmaltese\nmastiff: bull,english,tibetan\nmexicanhairless\nmix\nmountain: bernese,swiss\nnewfoundland\notterhound\novcharka: caucasian\npapillon\npekinese\npembroke\npinscher: miniature\npitbull\npointer: german,germanlonghair\npomeranian\npoodle: miniature,standard,toy\npug\npuggle\npyrenees\nredbone\nretriever: chesapeake,curly,flatcoated,golden\nridgeback: rhodesian\nrottweiler\nsaluki\nsamoyed\nschipperke\nschnauzer: giant,miniature\nsetter: english,gordon,irish\nsheepdog: english,shetland\nshiba\nshihtzu\nspaniel: blenheim,brittany,cocker,irish,japanese,sussex,welsh\nspringer: english\nstbernard\nterrier: american,australian,bedlington,border,cairn,dandie,fox,irish,kerryblue,lakeland,norfolk,norwich,patterdale,russell,scottish,sealyham,silky,tibetan,toy,welsh,westhighland,wheaten,yorkshire\ntervuren\nvizsla\nwaterdog: spanish\nweimaraner\nwhippet\nwolfhound: irish";
            //< Label Text = "{Binding MyStringProperty}" />

            var email = DependencyService.Get<IEmailClientService>();
            var res = await email.SendEmail("to","from","subject","body");
        }
    }

}

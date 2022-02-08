using DogsApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DogsApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
using AppLanches.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppLanches.Views
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
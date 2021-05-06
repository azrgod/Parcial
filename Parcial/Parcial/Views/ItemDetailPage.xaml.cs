using Parcial.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Parcial.Views
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
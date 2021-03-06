using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        private async void NavigatedButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemsPage());
        }
    }
}
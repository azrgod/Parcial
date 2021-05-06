using Parcial.Models;
using Parcial.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Parcial.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
        private void buttonGuardar_Clicked(object sender, EventArgs e)
        {
            var label = new Label {Text = Conductor.Text, BackgroundColor = Color.White, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, TextColor = Color.Black, FontSize = 50, };
            var label1 = new Label { Text = Marca.Text, BackgroundColor = Color.White, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, TextColor = Color.Black, FontSize = 50, };
            var label2 = new Label { Text = Modelo.Text, BackgroundColor = Color.White, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, TextColor = Color.Black, FontSize = 50, };
            Parcial.Children.Add(label);
            Parcial.Children.Add(label1);
            Parcial.Children.Add(label2);
        }
    }
}
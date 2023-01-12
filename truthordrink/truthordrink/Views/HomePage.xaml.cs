using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using truthordrink.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace truthordrink
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            SetValue(NavigationPage.HasNavigationBarProperty, false);
        }


        private void Spelen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Spelen());
        }

        private void MijnLijsten_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MijnLijsten());
        }

        async void Logout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private void DrinkPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DrinksPage());
        }
    }
}
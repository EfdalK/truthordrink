using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        private void Spelers_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Spelers());
        }

        private void Spelen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Spelen());
        }

        private void MijnLijsten_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MijnLijsten());
        }
    }
}
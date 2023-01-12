using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using truthordrink.Logic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace truthordrink.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrinksPage : ContentPage
    {
        public DrinksPage()
        {
            InitializeComponent();
        }

        private void CocktailSearchButton_Clicked(object sender, EventArgs e)
        {
            //var cocktails = CocktailLogic.GetCocktailsByName(CocktailNameEntry.Text);
            //CocktailListView.ItemsSource = cocktails;
        }
    }
}
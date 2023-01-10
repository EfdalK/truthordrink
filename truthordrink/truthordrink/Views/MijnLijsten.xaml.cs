using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using truthordrink.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace truthordrink
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MijnLijsten : ContentPage
	{
		public MijnLijsten ()
		{
			InitializeComponent ();
		}

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            Question question = new Question
            {
                QuestionBody = QuestionEntry.Text
            };

            SQLiteConnection sQLiteConnection = new SQLiteConnection(App.DatabaseLocation);
			sQLiteConnection.CreateTable<Question>();
			int insertedRows = sQLiteConnection.Insert(question);
			sQLiteConnection.Close();

			if(insertedRows > 0)
			{
				_ = DisplayAlert("gelukt!", "je vraag is goed toegevoegd aan de database.", "Ok");
			}
			else
			{
				_ = DisplayAlert("Ah, jammer! Er ging iets fout.", "je vraag is niet toegevoegd aan de database", "Ok");
			}

			await Navigation.PopAsync();

        }
    }
}
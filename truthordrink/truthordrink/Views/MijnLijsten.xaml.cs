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
				_ = DisplayAlert("Added!", "Your question has been added to the database", "Ok");
			}
			else
			{
				_ = DisplayAlert("Error!", "Something went wrong.", "Ok");
			}

			await Navigation.PopAsync();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection sQLiteConnection = new SQLiteConnection(App.DatabaseLocation))
            {
                sQLiteConnection.CreateTable<Question>();
                List<Question> questions = sQLiteConnection.Table<Question>().ToList();
				QuestionListView.ItemsSource = questions;
            }
        }

        private void QuestionListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedQuestion = QuestionListView.SelectedItem as Question;
            if(selectedQuestion != null)
            {
                Navigation.PushAsync(new MijnLijsten());
            }
        }
    }
}
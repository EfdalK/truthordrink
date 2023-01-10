using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using truthordrink.Tables;
using truthordrink.Views;
using Xamarin.Forms;

namespace truthordrink
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
        }

        void LoginButton_Clicked(object sender, EventArgs e)
        {
            /*
            bool isUsernameEmpty = string.IsNullOrEmpty(UsernameEntry.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(PasswordEntry.Text);

            if (isUsernameEmpty)
            {
                UsernameEntry.Placeholder = "Fill in username";
            }
            else if (isPasswordEmpty)
            {
                PasswordEntry.Placeholder = "Fill in password";
            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
            */
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<UserTable>().Where(u => u.UserName.Equals(UsernameEntry.Text) && u.Password.Equals(PasswordEntry.Text)).FirstOrDefault();

            if (myquery != null)
            {
                App.Current.MainPage = new NavigationPage(new HomePage());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {

                    var result = await this.DisplayAlert("Error", "Incorrect password or username", "Cancel", "Continue");

                    if (result)
                        await Navigation.PushAsync(new MainPage());
                    else
                    {
                        await Navigation.PushAsync(new MainPage());
                    }

                });
            }

        }

        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }
    }
}

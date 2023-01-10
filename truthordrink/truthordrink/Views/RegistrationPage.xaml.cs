using SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using truthordrink.Tables;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace truthordrink.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
        }


        void RegisterButton_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<UserTable>();

            var item = new UserTable()
            {
                UserName = EntryUsername.Text,
                Password = EntryPassword.Text
            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () => 
            {
                
                var result = await this.DisplayAlert("Congratulations", "User registered succesfully", "Cancel", "Continue");

                if (result)
                    await Navigation.PushAsync(new MainPage());
                else
                {
                    await Navigation.PushAsync(new MainPage());
                }
            
            });
        }
    }
}
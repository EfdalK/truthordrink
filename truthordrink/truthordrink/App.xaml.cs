﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Roboto-Regular.ttf", Alias = "Roboto-Regular")]
namespace truthordrink
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public App(string databaseLocation)
        {
            InitializeComponent();
            DatabaseLocation = databaseLocation;
            MainPage = new NavigationPage(new MainPage());
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

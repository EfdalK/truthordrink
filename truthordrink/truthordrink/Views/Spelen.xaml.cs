﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace truthordrink
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Spelen : ContentPage
	{
		public Spelen ()
		{
			InitializeComponent ();
		}

        private void StartButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GameScreen ());
        }
    }
}
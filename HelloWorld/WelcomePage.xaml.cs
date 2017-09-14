using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class WelcomePage : ContentPage
    {
		public WelcomePage()
		{
			InitializeComponent();
		}

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new IntroductionPage());
        }
    }
}

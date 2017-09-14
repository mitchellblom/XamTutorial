using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class IntroductionPage : ContentPage
    {
		public IntroductionPage()
		{
			InitializeComponent();
		}

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}

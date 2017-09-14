using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class PopupPage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            //var response = await DisplayAlert("Warning", "Are you sure?", "Yes", "No");
            //if (response)
                //DisplayAlert("Done", "Your response will be saved!", "OK");
            var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Message", "Email");
            await DisplayAlert("Response", response, "OK");
        }

        public PopupPage()
        {
            InitializeComponent();
        }
    }
}

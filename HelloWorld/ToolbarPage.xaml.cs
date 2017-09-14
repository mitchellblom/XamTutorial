using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class ToolbarPage : ContentPage
    {
        void Handle_Activated(object sender, System.EventArgs e)
        {
            DisplayAlert("Activated", "ToolbarItem Activated", "OK");
        }

        public ToolbarPage()
        {
            InitializeComponent();
        }
    }
}

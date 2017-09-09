using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class GreetPage : ContentPage
    {

        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 0.5;

            if (Device.RuntimePlatform == Device.iOS)
            {
                Padding = new Thickness(0, 20, 0, 0);
            }
        }
    }

}
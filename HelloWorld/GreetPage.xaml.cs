using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]

namespace HelloWorld
{
    public partial class GreetPage : ContentPage
    {
        private int _i = 0;
        private string[] _quotes = new string[]
        {
            "Life is like a box of chocolates.",
            "I'm sorry, Wilson!",
            "Houston, we have a problem."
        };

        public GreetPage()
        {
            InitializeComponent();

            currentQuote.Text = _quotes[_i];

            slider.Value = 14;

            //Padding = GetPagePadding();

        }

		void Handle_Clicked(object sender, System.EventArgs e)
		{
            _i++;
            if (_i >= _quotes.Length)
                _i = 0;

            currentQuote.Text = _quotes[_i];
		}

        private static Thickness GetPagePadding()
        {
            double topPadding;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    topPadding = 20;
                    break;
                default:
                    topPadding = 0;
                    break;
            }

            return new Thickness(5, topPadding, 5, 0);
        }

    }
}
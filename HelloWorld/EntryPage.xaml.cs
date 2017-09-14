using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class EntryPage : ContentPage
    {
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            label.Text = e.NewTextValue;
        }

        public EntryPage()
        {
            InitializeComponent();
        }
    }
}

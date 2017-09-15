using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MainPageAppProps : ContentPage
    {

        //void OnChange(object sender, System.EventArgs e)
        //{
        //    var app = Application.Current as App;
        //    app.Title = title.Text;
        //    app.NotificationsEnabled = notificationsEnabled.On;

        //    //Application.Current.SavePropertiesAsync(); // saves asap instead of waiting til app is in bkrnd or quit
        //}

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        public MainPageAppProps()
        {
            InitializeComponent();

            BindingContext = Application.Current;
        }
    }
}

using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MainPageAppProps : ContentPage
    {
        void OnChange(object sender, System.EventArgs e)
        {
            Application.Current.Properties["Name"] = title.Text;
            Application.Current.Properties["NotificationsEnabled"] = notificationsEnabled.On;

            //Application.Current.SavePropertiesAsync(); // saves asap instead of waiting til app is in bkrnd or quit
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        public MainPageAppProps()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("Name"))
                title.Text = Application.Current.Properties["Name"].ToString();

			if (Application.Current.Properties.ContainsKey("NotificationsEnabled"))
                notificationsEnabled.On = (bool) Application.Current.Properties["NotificationsEnabled"];

                
        }
    }
}

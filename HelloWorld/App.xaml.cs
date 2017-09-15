using System;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class App : Application
    {
		private const string TitleKey = "Name";
		private const string NotificationsEnabledKey = "NotificationsEnabled";

        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<CloudDataStore>();

            //MainPage = new NavigationPage (new ContactsPage()){  
            MainPage = new InteractSQLPage() {
                //BarBackgroundColor = Color.Gray,
                //BarTextColor = Color.White
            };
        }

        public string Title
        {
            get 
            {
                if (Properties.ContainsKey(TitleKey))
                    return Properties[TitleKey].ToString();

                return "";
            }
            set
            {
                Properties[TitleKey] = value;    
            }
        }

        public bool NotificationsEnabled
		{
			get
			{
				if (Properties.ContainsKey(NotificationsEnabledKey))
					return (bool)Properties[NotificationsEnabledKey];

                return false;
			}
			set
			{
				Properties[NotificationsEnabledKey] = value;
			}
		}
    }
}
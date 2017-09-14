﻿using System;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class App : Application
    {
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
            MainPage = new EntryPage() {
                //BarBackgroundColor = Color.Gray,
                //BarTextColor = Color.White
            };
        }
    }
}
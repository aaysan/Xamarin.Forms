﻿using Xamarin.Forms;

namespace SmsPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TestPage())
            {
                BarBackgroundColor = Color.Black,
                BarTextColor = Color.AntiqueWhite,

            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

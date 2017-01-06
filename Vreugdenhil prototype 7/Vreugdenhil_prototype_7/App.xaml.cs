using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Vreugdenhil_prototype_7
{
    public partial class App : Application
    {
        public static bool LoggedIn { get; set; }

        public App()
        {
            InitializeComponent();

            if (!LoggedIn)
                MainPage = new NavigationPage(new Login())
                {
                    BarTextColor = Color.White,
                    BarBackgroundColor = new Color(66, 134, 244),
                    BackgroundColor = new Color(66, 134, 244)
                };
            else
                MainPage = new NavigationPage(new MainPage())
                {
                    BarTextColor = Color.White,
                    BarBackgroundColor = new Color(66, 134, 244),
                    BackgroundColor = new Color(66, 134, 244)
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

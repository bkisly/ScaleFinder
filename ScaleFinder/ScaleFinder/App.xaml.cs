using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ScaleFinder.Views;

namespace ScaleFinder
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new FinderPage())
            {
                BarBackgroundColor = Color.FromHex("#323232"),
                BarTextColor = Color.FromHex("#f0f0f0"),
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

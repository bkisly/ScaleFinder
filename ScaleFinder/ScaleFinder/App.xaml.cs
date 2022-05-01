﻿using System;
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

            MainPage = new FinderPage();
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
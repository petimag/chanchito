﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prueba
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static MasterDetailPage Modificador { get; set; }

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

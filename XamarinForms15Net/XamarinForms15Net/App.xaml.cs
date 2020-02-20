﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms15Net.Views;

namespace XamarinForms15Net
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Cadastro();
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

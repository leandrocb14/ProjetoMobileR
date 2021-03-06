﻿using ProjetoMobile.Model;
using ProjetoMobile.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ProjetoMobile
{
    public partial class App : Application
    {        
        public App()
        {
            InitializeComponent();
            MainPage = new LoginView();            

        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MessagingCenter.Subscribe<Login>(this, "SucessoLogin", (msg) =>
            {
                MainPage = new MasterDetailView();
            });
            MessagingCenter.Subscribe<string>(this, "UsuarioDeslogado", (msg) =>
            {
                MainPage = new LoginView();
            });
            
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
﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Foodatory1;
using Foodatory1.Models;

namespace Foodatory1
{
    public partial class App : Application
    {
       
            public App()
            {
                InitializeComponent();


                //var nv = new NavigationPage(new Web);
                //nv.BarBackgroundColor = Color.Red;
                //nv.BarTextColor = Color.White;

                //MainPage = new MainPage();
                // MainPage = new NavigationPage(new MainPage());
                // MainPage.Icon = "dicon.png";
                MainPage = new NavigationPage(new Splash());

            }
            public void OnSkip()
            {
                MainPage = new Recipe1();

            }


            public void OnLogin()
                {
                    MainPage = new AfterLoginPage();

                }

         public void OnSignUp()
         {
            
               MainPage = new LoginPage();

         }
        public void OnAddRecipe()
        {
            MainPage = new AddRecipe();
        }
        public void OnAddInventory()
        {
            MainPage = new AddInventory();
        }
        
        public void OnRecipeDetails(string name,string procedure,string ingredients)
        {

            //await Navigation.PushAsync(new RecipeDetails(name, procedure, ingredients));
         //  MainPage = new RecipeDetails(name,procedure,ingredients);

            MainPage = new RecipeDetails(name, procedure, ingredients);
        }

        public void OnLoginLabel()
            {
                MainPage = new LoginPage();

            }

            public void OnSignupLabel()
            {
                MainPage = new Signup();

            }

            public void OnSignup()
            {
                MainPage = new AfterLoginPage();

            }
            public void OnLogout()
            {
                MainPage = new NavigationPage(new LoginPage());
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
        public void OnBack()
        {
            MainPage = new AfterLoginPage();
        }
    }
    }


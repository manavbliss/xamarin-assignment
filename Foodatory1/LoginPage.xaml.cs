using System;
using System.Collections.Generic;
using Foodatory1.Models;
using Foodatory1.Services;
using Xamarin.Forms;

namespace Foodatory1
{
    public partial class LoginPage : ContentPage
    {
        FirebaseService service;
        public LoginPage()
        {
            InitializeComponent();
            service = new FirebaseService();
        }
        void Handle_Clicked1(object sender, System.EventArgs e)
        {
            var myApp = Application.Current as App;
            myApp.OnSkip();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var myApp = Application.Current as App;
            myApp.OnLogin();
        }

        void OnSignupLabel(object sender, System.EventArgs e)
        {
            var myApp = Application.Current as App;
            myApp.OnSignupLabel();
        }
        async void onSignIn(object sender, System.EventArgs e)
        {
            List<User> allUsers = new List<User>();
            allUsers = await service.GetAllUsers();
            Console.WriteLine("Count:: " + allUsers.Count);
            bool userFound = false;
            foreach (User user in allUsers)
            {
                Console.WriteLine("UserName:: " + user.username);
                if(user.username == username.Text && user.password == password.Text)
                {
                    Console.WriteLine("==========User Found");
                    userFound = true;
                    var myApp = Application.Current as App;
                    myApp.OnLogin();
                }
            }
            if (userFound == false)
            {
                await DisplayAlert("Invalid Credentials","Username or Password is wrong","Okay");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using Foodatory1.Models;
using Foodatory1.Services;
using Xamarin.Forms;

namespace Foodatory1
{
    public partial class Signup : ContentPage
    {
        FirebaseService service;

        public Signup()
        {
            InitializeComponent();

            service = new FirebaseService();
        }
        //void Handle_Clicked(object sender, System.EventArgs e)
        //{


        //    if (email.Text == "" || username.Text == "" || password.Text == "" || cPassword.Text == "")
        //    {
        //        DisplayAlert("Emp", "All fields are mandatory", "Ok");
        //    }
        //    else
        //    {
        //        if (password == cPassword)
        //        {
        //            var myApp = Application.Current as App;
        //            myApp.OnSignUp();
        //        }
        //        else
        //        {
        //            DisplayAlert("Password Alert", "Password not matches", "Ok");
        //        }
        //    }

        //}

        void OnLoginLabel(object sender, System.EventArgs e)
        {
            var myApp = Application.Current as App;
            myApp.OnLoginLabel();
        }

         async void OnSignUp(object sender, System.EventArgs e)
        {
            Console.WriteLine("Kavya" +email.Text);
            Console.WriteLine("Kavya" + username.Text);
            Console.WriteLine("Kavya" + password.Text);
            Console.WriteLine("Kavya" + cPassword.Text);

            //if (email.Text == "" || username.Text == "" || password.Text == "" || cPassword.Text == "")
            //{
            //    await DisplayAlert("Emp", "All fields are mandatory", "Ok");
            //}
            //else
            //{
            //    if (password == cPassword)
            //    {
                    List<User> allUsers = new List<User>();
                    allUsers = await service.GetAllUsers();
                    int id = allUsers.Count + 1;
                    // User user = new User(id, username.Text,email.Text,password.Text);
                    await service.AddUser(id, username.Text, email.Text, password.Text);
                    await DisplayAlert("Success", "User added successfully", "Ok");
                    //login page
                    var myApp = Application.Current as App;
                    myApp.OnLoginLabel();
                //}
                //else
                //{
                //   await DisplayAlert("Password Alert", "Password not matches", "Ok");
                //}
            

           


        }

    }
}

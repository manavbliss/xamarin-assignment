using System;
using System.Collections.Generic;
using Foodatory1.Models;
using Foodatory1.Services;
using Xamarin.Forms;

namespace Foodatory1
{
    public partial class AddRecipe : ContentPage
    {
        FirebaseService service;
        public AddRecipe()
        {
            service = new FirebaseService();
            InitializeComponent();
        }

        async void Add(object sender, System.EventArgs e)
        {
            //Recipe r = new Recipe(name.Text,procedure.Text,ingredients.Text);
            await service.AddRecipe(name.Text, procedure.Text, ingredients.Text);
            await DisplayAlert("Success", "Recipe Added Successfully", "Ok");
            var myApp = Application.Current as App;
            myApp.OnBack();
        }
        void back(object sender, System.EventArgs e)
        {
            var myApp = Application.Current as App;
            myApp.OnBack();
        }
    }
}

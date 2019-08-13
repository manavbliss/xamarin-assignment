using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Foodatory1.Models;
using Foodatory1.Services;
using Xamarin.Forms;

namespace Foodatory1
{
    public partial class Recipe1 : ContentPage

    {
        public ObservableCollection<string> Items { get; set; }
        FirebaseService service;

        public Recipe1()
        {

            InitializeComponent();
            service = new FirebaseService();

        }

        protected async override void OnAppearing()
        {
            Console.WriteLine("Recipe On Appearing");
            base.OnAppearing();
            List<Recipe> recipes = await service.GetAllRecipes();
            foreach(Recipe r in recipes)
            {
                Console.WriteLine("Name:: "+r.name);
            }
            listView.ItemsSource = recipes;
            //your code here;

        }
        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return; 
            Recipe r = (Foodatory1.Models.Recipe)e.SelectedItem;

           
            var myApp = Application.Current as App;
            myApp.OnRecipeDetails(r.name,r.procedure,r.ingredients);


        }
        public void OnMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");

            Debug.WriteLine("delete " + mi.CommandParameter.ToString());
            Items.Remove(mi.CommandParameter.ToString());

        }
    }
}


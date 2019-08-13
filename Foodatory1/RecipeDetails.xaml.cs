using System;
using System.Collections.Generic;
using Foodatory1.Models;
using Xamarin.Forms;

namespace Foodatory1
{
    public partial class RecipeDetails : ContentPage
    {
        public string rName;
        public string procedure;
        public string ingredients;

        public RecipeDetails()
        {
            InitializeComponent();
           
        }

        public RecipeDetails(string name,string procedure,string ingredients)

        {
            InitializeComponent();
            rName = name;
            this.procedure = procedure;
            this.ingredients = ingredients;

            
        }

        protected override void OnAppearing()
        {
            Console.WriteLine(rName);
            name.Text = rName;
            description.Text = "Description: " +procedure;
            ringredients.Text = "Ingredients: " + ingredients;


        }
        void back(object sender, System.EventArgs e)
        {
            var myApp = Application.Current as App;
            myApp.OnBack();
        }

    }
}

using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Foodatory1
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        void recipePage(object sender, System.EventArgs e)
        {

            var myApp = Application.Current as App;
            myApp.OnAddRecipe();

        }

        void inventoryPage(object sender, System.EventArgs e)
        {
            var myApp = Application.Current as App;
            myApp.OnAddInventory();
        }
    }
}

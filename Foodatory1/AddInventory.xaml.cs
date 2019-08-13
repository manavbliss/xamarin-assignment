using System;
using System.Collections.Generic;
using Foodatory1.Services;
using Xamarin.Forms;

namespace Foodatory1
{
    public partial class AddInventory : ContentPage
    {
        FirebaseService service;
        public AddInventory()
        {
            InitializeComponent();
            service = new FirebaseService();
        }

       async void save(object sender, System.EventArgs e)
        {
           await service.AddInventory(name.Text);
            await DisplayAlert("Success", "Inventory Added Successfully", "Ok");
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

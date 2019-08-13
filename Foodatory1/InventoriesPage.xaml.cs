using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Foodatory1.Models;
using Foodatory1.Services;
using Xamarin.Forms;

namespace Foodatory1
{
    public partial class InventoriesPage : ContentPage
    {
        FirebaseService service;
        public ObservableCollection<string> Items { get; set; }
        public InventoriesPage()
        {
            
            InitializeComponent();
            service = new FirebaseService();
            
            //listView.ItemsSource = new[] { "Inventory1", "Inventory2", "Inventory3" };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            List<Inventory> inventories= await service.GetAllInventories();
            foreach (Inventory i in inventories)
            {
                Console.WriteLine("Name:: " + i.name);
            }

          listView.ItemsSource = inventories;
        }

        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return; // has been set to null, do not 'process' tapped event
            //DisplayAlert("Tapped", e.SelectedItem + " row was tapped", "OK");
            //((ListView)sender).SelectedItem = null; // de-select the row
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

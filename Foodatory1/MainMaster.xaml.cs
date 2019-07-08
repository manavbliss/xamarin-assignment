using System;
using System.Collections.Generic;
using Foodatory1;

using Xamarin.Forms;

namespace Foodatory1
{
    public partial class MainMaster : ContentPage
    {
        MasterDetailPage myMaster;
        public MainMaster(MasterDetailPage _myMaster)
        {
            myMaster = _myMaster;
            InitializeComponent();
        }

        void Products_Handle_Clicked(object sender, System.EventArgs e)
        {
            myMaster.Detail = new NavigationPage(new HomePage());
            myMaster.IsPresented = false;

        }

        void Recipe_Handle_Clicked(object sender, System.EventArgs e)
        {
            myMaster.Detail = new NavigationPage(new Recipe1());
            myMaster.IsPresented = false;

        }
        void Settings_Handle_Clicked(object sender, System.EventArgs e)
        {
            //myMaster.Detail = new NavigationPage(new SettingsPage());
            //myMaster.IsPresented = false;

            var myApp = Application.Current as App;
            myApp.OnLogout();

        }
        void Inv_Handle_Clicked(object sender, System.EventArgs e)
        {
            myMaster.Detail = new NavigationPage(new InventoriesPage());
            myMaster.IsPresented = false;

        }
    }
}

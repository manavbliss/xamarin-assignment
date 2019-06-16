using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Foodatory1
{
    public partial class Signup : ContentPage
    {
        public Signup()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var myApp = Application.Current as App;
            myApp.OnLogin();
        }

        void OnLoginLabel(object sender, System.EventArgs e)
        {
            var myApp = Application.Current as App;
            myApp.OnLoginLabel();
        }
    }
}

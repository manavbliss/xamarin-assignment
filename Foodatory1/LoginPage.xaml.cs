using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Foodatory1
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
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
    }
}

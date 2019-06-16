using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Foodatory1
{
    public partial class Splash : ContentPage
    {
        public Splash()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();



            await Task.Delay(3000);

            await Navigation.PushModalAsync(new LoginPage());


        }
    }
}

using System;
using System.Collections.Generic;
using Foodatory1;

using Xamarin.Forms;

namespace Foodatory1
{
    public partial class AfterLoginPage : MasterDetailPage
    {
        public AfterLoginPage()
        {
            var masterPage = new MainMaster(this);
            Master = masterPage;
            Detail = new NavigationPage(new HomePage());

            InitializeComponent();
        }
     }
}

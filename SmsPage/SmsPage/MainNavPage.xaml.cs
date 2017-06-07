using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SmsPage
{
    public partial class MainNavPage : TabbedPage
        public MainNavPage()
        {

        var navigationPage = new NavigationPage(new SmsPage());
			navigationPage.Icon = "schedule.png";
			navigationPage.Title = "Schedule";
       
        }
    }
}

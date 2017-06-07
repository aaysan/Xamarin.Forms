using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SmsPage
{
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SmsPage{
                Title = "SMS PAGE",
            });
        }
    }
}

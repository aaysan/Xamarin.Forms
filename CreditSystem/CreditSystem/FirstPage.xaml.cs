using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CreditSystem
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ProductDetsForm(){
                Title = "FORM"
            });
        }
    }


}

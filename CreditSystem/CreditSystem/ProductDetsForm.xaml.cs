using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CreditSystem
{
    public partial class ProductDetsForm : ContentPage
    {
        public ProductDetsForm()
        {
            InitializeComponent();

            clientcell.View.BackgroundColor = Color.Transparent;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ProductDetails(){
                Title = "FINANSAL FIRSATLAR"
            });
        }
    }
}

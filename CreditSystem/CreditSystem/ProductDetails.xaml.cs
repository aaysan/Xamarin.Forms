using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CreditSystem
{
    public partial class ProductDetails : ContentPage
    {
        public ProductDetails()
        {
            InitializeComponent();

            CurrencyPicker.Items.Add("USD");
            CurrencyPicker.Items.Add("TL");

            List<FinancialOpportunities> opportunity = new List<FinancialOpportunities>{
                new FinancialOpportunities{
                    info = "Hayellerinizi sınırlamayın diye faizleri sıfırladık!",
                    carimage = "carcar.png",
                    rates = "faiz.png"
                },
                new FinancialOpportunities{
                    info = "Sizi bir Mercedes-benz sahibi yapma konusunda çok ciddiyiz.",
                    carimage = "car12.png",
                    rates = "faiz.png"
                },
                new FinancialOpportunities{
                    info = "scrollview icin acilmis olan ucuncu kampanya, lore ipsum lore ipsum",
                    carimage = "carcar.png",
                    rates = "faiz.png"
                }
            };

            opports.ItemsSource = opportunity;
            opports.SeparatorColor = Color.Transparent;

            monthlypayment.Text = (CreditSlider.Value / 125).ToString();

     
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ApplicationPage(){
                Title = "GOZDEN GECIRIN"
            });
        }
    }
}

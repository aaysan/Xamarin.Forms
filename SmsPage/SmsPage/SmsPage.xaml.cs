using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SmsPage
{
    public partial class SmsPage : ContentPage
    {
 

        public SmsPage()
        {
            InitializeComponent();
            var phone = "5343265151";

            for (int i = 3; i < phone.Length - 2; i++)
            {
                phone = phone.Remove(i, 1).Insert(i, "*");
            }

            phonelabel.Text = "Lutfen " + phone + " numarali telefonunuza gelen dogrulama kodunu giriniz";
        }


		void Handle_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
            
        }
    }
}

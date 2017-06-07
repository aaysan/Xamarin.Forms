﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CreditSystem
{
    public partial class ApplicationPage : ContentPage
    {
        public ApplicationPage()
        {
            InitializeComponent();
        }

        void Handle_ClickedButton1(object sender, System.EventArgs e)
        {
            Button1.TextColor = Color.Blue;
            Button2.TextColor = Color.Gray;
            Button3.TextColor = Color.Gray;
        }

        void Handle_ClickedButton2(object sender, System.EventArgs e)
        {
			Button1.TextColor = Color.Gray;
            Button2.TextColor = Color.Blue;
			Button3.TextColor = Color.Gray;
        }

        void Handle_ClickedButton3(object sender, System.EventArgs e)
        {
            Button1.TextColor = Color.Gray;
			Button2.TextColor = Color.Gray;
            Button3.TextColor = Color.Blue;
        }

        void Handle_ClickedDoneButton(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FinalPage(){});
        }
    }
}

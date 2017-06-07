using System;
using Xamarin.Forms;

namespace SimpleListView
{
    public class SimpleList : ContentPage
    {
        public SimpleList()
        {
            Title = "Simple";
            Padding = new Thickness(0, 20, 0, 0);

            var listview = new ListView();
            listview.ItemsSource = Data.StringList;
            Content = listview;
        }
    }
}

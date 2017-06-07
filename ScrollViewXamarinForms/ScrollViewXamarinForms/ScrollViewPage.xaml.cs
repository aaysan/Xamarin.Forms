using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ScrollViewXamarinForms
{
    public partial class ScrollViewPage : ContentPage
    {
        public ScrollViewPage()
        {
			StackLayout stack = new StackLayout();
            for (var i = 0; i < 100; i++)
                {
                if (i % 2 == 0)
                {
                    stack.Children.Add(new Button { Text = "Button " + i });
                }
                else
                {
                    stack.Children.Add(new Button { Text = "Button " + i, Image = "profile_generic.png" });
                }
                
            }
            /*var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto)});
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star)});
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto)});
            var topRight = new Label { Text = "Merso", VerticalTextAlignment = TextAlignment.Center, HorizontalTextAlignment = TextAlignment.Center, TextColor = Color.Red, FontSize = 16 };
            var bottomLeft = new Image { Source = "tab_about.png", Scale = 0.2 };
            var topLeft = new Label { Text = "Hi", HorizontalTextAlignment = TextAlignment.Center, FontSize = 16 };
            //var Gg = new Label { BackgroundColor = Color.Red, Scale = 0.2 };

            grid.Children.Add(topRight, 0, 1);
            grid.Children.Add(bottomLeft, 0, 1);
            //grid.Children.Add(Gg, 0, 2);
            grid.Children.Add(topLeft, 0, 3);*/



            ScrollView scroll = new ScrollView
            {
                Content = stack
                //Content = grid
            };
            Content = scroll;
			Title = "ScrollView";
        }
    }
}

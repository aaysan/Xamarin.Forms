using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace CampaignPage
{

    public partial class CampPage : ContentPage
    {
        //ObservableCollection<Campaings> kampanya = new ObservableCollection<Campaings>();
        public CampPage()
        {
            InitializeComponent();
            /*CampView.ItemsSource = kampanya;



            kampanya.Add(new Campaings
            {
                camptext = "Alp",
                dets = "Aysan",
                cars = ImageSource.FromFile("backimage.jpg")
            });

            kampanya.Add(new Campaings
            {
                camptext = "B serisinde Sok Indirim",
                dets = "Ilginizi cekebilir",
                cars = ImageSource.FromFile("backimage.jpg")
            });
*/

            Label header = new Label
            {
                Text = "Kampanyalar",
                TextColor = Color.Black,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Center,
                //BackgroundColor = Color.BlanchedAlmond
            };

            Button backbutton = new Button
            {
                Text = "<",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Black,
                //BackgroundColor = Color.BlanchedAlmond
            };

            RelativeLayout relativeLayout = new RelativeLayout();

            Image carsimg = new Image
            {
                Aspect = Aspect.Fill,
                Source = "backimage.jpg"
            };

            relativeLayout.Children.Add(carsimg,
                                        Constraint.Constant(0),
                                        Constraint.RelativeToParent((parent) => { return 0; }));

            Label merso = new Label
            {
                Text = "Mercedes",
                TextColor = Color.AntiqueWhite,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Start
            };
            relativeLayout.Children.Add(merso,
            Constraint.Constant(0),
            Constraint.RelativeToParent((parent) =>
            {
                return 75;
            }));

            Label merso2 = new Label
            {
                Text = "The Best",
                TextColor = Color.AntiqueWhite,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                HorizontalTextAlignment = TextAlignment.Start
            };

            relativeLayout.Children.Add(merso2,
                                        Constraint.Constant(0),
                                        Constraint.RelativeToView(merso, (parent, sibling) =>
                                        {
                                            return sibling.Y + sibling.Height;
                                        }));
            Button upbutton = new Button
            {
                Text = "^",
                TextColor = Color.Black,
                BackgroundColor = Color.AntiqueWhite
            };

            relativeLayout.Children.Add(upbutton,
                                        Constraint.RelativeToParent((parent) =>
                                        {
                                            return parent.Width / 2;
                                        }),
                                        Constraint.Constant(0));


            // Build the page.
            Grid grid = new Grid
            {
                RowDefinitions = {
                    new RowDefinition { Height = 40 },
                    new RowDefinition { Height = new GridLength(1,GridUnitType.Auto) }
                },
                ColumnDefinitions = {
                    new ColumnDefinition { Width = 40},
                    new ColumnDefinition { Width = new GridLength(1,GridUnitType.Auto)}
                }
            };

			grid.Children.Add(header, 1, 0);
            grid.Children.Add(backbutton, 0, 0);
			grid.Children.Add(relativeLayout, 0, 1);
            Grid.SetColumnSpan(relativeLayout,2);
            grid.ColumnSpacing = 0;
			Content = grid;
		}



    }
}
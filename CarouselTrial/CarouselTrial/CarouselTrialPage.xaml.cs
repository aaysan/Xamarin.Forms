using Xamarin.Forms;
using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;

namespace CarouselTrial
{
    public partial class CarouselTrialPage : ContentPage
    {
        public List<CarCampaign> campaigns { get; set; }
        public CarouselTrialPage()
        {
            InitializeComponent();

            campaigns = new List<CarCampaign>
            {
                new CarCampaign{
                    header = "Mercedes",
                    info = "Yeniliklerle sizinle",
                    imageurl = "https://www.mercedes-amg.com/img/language_screen/carBG.jpg"
                },
                new CarCampaign{
                    header = "E-Serisi",
                    info = "Dudak ucuklatan fiyatlarla",
                    imageurl = "https://assets.mbusa.com/vcm/MB/DigitalAssets/Vehicles/ClassLanding/2014/E/Coupe/Gallery/2014-E-CLASS-COUPE-GALLERY-015-WR-D.jpg"
                }
            };

            CampaignCars.ItemsSource = campaigns;



        }
    }
}

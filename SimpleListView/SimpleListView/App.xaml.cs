using System.Collections.Generic;

using Xamarin.Forms;

namespace SimpleListView
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            var tabs = new TabbedPage();
            tabs.Children.Add(new SimpleList());

            MainPage = tabs;

        }

		protected override void OnStart()
		{
			//Debug.WriteLine("OnStart");
		}
		protected override void OnSleep()
		{
			//Debug.WriteLine("OnSleep");
		}
		protected override void OnResume()
		{
			//ßDebug.WriteLine("OnResume");
		}



	}
}

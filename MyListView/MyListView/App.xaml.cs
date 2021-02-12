using MyListView.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyListView
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HumanPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

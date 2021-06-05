using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamPF.Views;

namespace XamPF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AudioBookPage());
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

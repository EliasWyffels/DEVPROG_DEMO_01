using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using _01DEMO.Services;
using _01DEMO.Views;

namespace _01DEMO
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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

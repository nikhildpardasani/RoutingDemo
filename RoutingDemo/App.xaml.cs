using System;
using RoutingInShell;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RoutingDemo
{
    public partial class App : Application
    {

        public static bool IsRunning = false;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

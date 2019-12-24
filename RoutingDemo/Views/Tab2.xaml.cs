using System;
using System.Collections.Generic;
using RoutingDemo;
using Xamarin.Forms;

namespace RoutingInShell.Views
{
    public partial class Tab2 : ContentPage
    {
        public Tab2()
        {
            InitializeComponent();
        }

        void OnButton1Clicked(object sender, EventArgs args)
        {
            Shell.Current.GoToAsync("Tab2/Tab2A");
        }

        void OnButton2Clicked(object sender, EventArgs args)
        {
            Shell.Current.GoToAsync("Tab2/Tab2B");
        }

        void OnButton3Clicked(object sender, EventArgs args)
        {
            Shell.Current.GoToAsync("Tab2/Tab2C");
        }

        void OnButton4Clicked(object sender, EventArgs args)
        {
            App.IsRunning = !App.IsRunning;
            if(App.IsRunning)
            {
                btn1.Text = "Click here to Stop the work";
            }
            else
            {
                btn1.Text = "Click here to Start the work";
            }
        }
    }
}

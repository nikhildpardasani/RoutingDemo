using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RoutingInShell.Views
{
    public partial class Tab1A : ContentPage
    {
        public Tab1A()
        {
            InitializeComponent();
        }

        void OnButton1Clicked(object sender, EventArgs args)
        {
            Shell.Current.GoToAsync("Tab1/Tab1B");
        }
    }
}

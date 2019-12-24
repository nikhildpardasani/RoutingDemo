using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using RoutingDemo;
using RoutingDemo.Helper;
using RoutingInShell.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RoutingInShell
{
    public partial class AppShell : Shell
    {
        Random rand = new Random();
        Dictionary<string, Type> routes = new Dictionary<string, Type>();
        public Dictionary<string, Type> Routes { get { return routes; } }
        List<string> ListOfTabs = new List<string> { "Tab1", "Tab2", "Tab3", "Tab4", "Tab5" };

        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
            this.Navigating += AppShell_Navigating;

            Routing.RegisterRoute("Tab1/Tab1A", typeof(Tab1A));
            Routing.RegisterRoute("Tab1/Tab1B", typeof(Tab1B));
            Routing.RegisterRoute("Tab1/Tab1C", typeof(Tab1C));

            Routing.RegisterRoute("Tab2/Tab2A", typeof(Tab2A));
            Routing.RegisterRoute("Tab2/Tab2B", typeof(Tab2B));
            Routing.RegisterRoute("Tab2/Tab2C", typeof(Tab2C));

            Routing.RegisterRoute("Tab3/Tab3A", typeof(Tab3A));
            Routing.RegisterRoute("Tab3/Tab3B", typeof(Tab3B));
            Routing.RegisterRoute("Tab3/Tab3C", typeof(Tab3C));
        }

        private async void AppShell_Navigating(object sender, ShellNavigatingEventArgs e)
        {
            Debug.WriteLine("Target:-\n" + e.Target.Location.OriginalString + "\n");
            if (e.Source == ShellNavigationSource.ShellSectionChanged && App.IsRunning)
            {
                e.Cancel();
                var abc = e.Target.Location.OriginalString;
                string target = ListOfTabs.FirstOrDefault(e.Target.Location.OriginalString.Contains);
                if (target != "Tab2")
                    if (await Shell.Current.DisplayAlert($"Stop Work", $"{Environment.NewLine}You tapped the {target} icon at the bottom of this page. The quiz will be stopped and you will be taken to the {target} screen.{Environment.NewLine}{Environment.NewLine}Please confirm{Environment.NewLine}", "OK", "Cancel") == true)
                    {
                        //if (e.Target.Location.OriginalString.Contains("DictionaryTab"))
                        //    await Helper.OpenPageAsync("//TabBar12/Tab5/DictionaryTab");
                        //else
                            await Helper.OpenPageAsync(e.Target.Location.OriginalString);
                    }
            }
        }
    }
}

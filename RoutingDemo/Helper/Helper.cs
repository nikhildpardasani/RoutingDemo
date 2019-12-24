using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RoutingDemo.Helper
{
    public static class Helper
    {
        public static async Task OpenPageAsync(string route)
        {
            try
            {
                Debug.WriteLine("Route:-\n" + route + "\n");
                await Shell.Current.GoToAsync(route, Device.RuntimePlatform != Device.iOS);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

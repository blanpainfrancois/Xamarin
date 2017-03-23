using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Challenge2_navigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_GoToPage1(object sender, EventArgs e)
        {
             
            await Navigation.PushAsync(new Page1());
        }

        private async void Button_GoToPage2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}

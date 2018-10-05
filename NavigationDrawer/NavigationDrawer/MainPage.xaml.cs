using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationDrawer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            hamburgerButton.Image = (FileImageSource)ImageSource.FromFile("hamburgericon.png");
            List<string> list = new List<string>();
            list.Add("Home");
            list.Add("Page 1");
            list.Add("Page 2");
            listView.ItemsSource = list;
        }
        void hamburgerButton_Clicked(object sender, EventArgs e) => navigationDrawer.ToggleDrawer();

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem.ToString() == "Home")
            {
                await Navigation.PushAsync(new MainPage());
            }
            else if (e.SelectedItem.ToString() == "Page 1")
            {
                await Navigation.PushAsync(new Page1());
            }
            else if (e.SelectedItem.ToString() == "Page 2")
            {
                await Navigation.PushAsync(new Page2());
            }

            navigationDrawer.ToggleDrawer();
        }
    }
}

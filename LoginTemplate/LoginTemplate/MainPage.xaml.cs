/**
 * Created by Andrew Huynh
 * Last Updated: May 13, 2018
 */
using System;
using Xamarin.Forms;

namespace LoginTemplate
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        // button that simply navigates back to the previous page
        async void BtnLogoutClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

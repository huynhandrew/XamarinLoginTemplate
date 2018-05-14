/** 
 * Created by Andrew Huynh
 * Last Updated: May 13, 2018
 */
using System;
using LoginTemplate.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginTemplate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
        // Include our login viewmodel
        LoginVM lvm = new LoginVM();

		public Login ()
		{
			InitializeComponent ();
            BindingContext = lvm;
		}

        /**
         * BtnLoginClicked
         * handles the communication of the view and view model
         * It will navigate to a new page if the login is successful.
         */
        async void BtnLoginClicked(object sender, EventArgs e)
        {
            if (lvm.Username == null)
            {
                LblErrMsg.IsVisible = true;
                LblErrMsg.Text = "Please enter a username";
                EntUser.PlaceholderColor = Color.Red;
            }
            else if (lvm.Password == null)
            {
                LblErrMsg.IsVisible = true;
                LblErrMsg.Text = "Please enter a password";
                EntPass.PlaceholderColor = Color.Red;
            }
            else {
                if (!lvm.Login())
                {
                    LblErrMsg.IsVisible = true;
                    LblErrMsg.Text = "Incorrect password or username";
                }
                else
                {
                    await Navigation.PushAsync(new MainPage());
                }
            }
        }
    }
}
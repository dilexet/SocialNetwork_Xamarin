using System;

namespace SocialNetwork.Views.Authorize
{
    public partial class RegisterPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            Xamarin.Forms.NavigationPage.SetHasBackButton(this, false);
        }

        private void UsernameText_OnTextChanged(object sender, EventArgs e)
        {
        }

        private void EmailText_OnTextChanged(object sender, EventArgs e)
        {
        }

        private void PasswordText_OnTextChanged(object sender, EventArgs e)
        {
        }

        private void ConfirmPasswordText_OnTextChanged(object sender, EventArgs e)
        {
        }

        private async void RedirectToSignIn_Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage(), false);
        }
    }
}
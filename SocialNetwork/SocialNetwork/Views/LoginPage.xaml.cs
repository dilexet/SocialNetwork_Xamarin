using System;
using Xamarin.Forms;

namespace SocialNetwork.Views
{
    public partial class LoginPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }

        private void LoginText_OnTextChanged(object sender, EventArgs e)
        {
            var isLoginEmpty = string.IsNullOrEmpty(LoginText.Text);
            if (isLoginEmpty)
            {
                ButtonSubmit.IsEnabled = false;
                LoginText.AssistiveText = "Field is required";
                return;
            }

            LoginText.AssistiveText = "";

            if (!string.IsNullOrEmpty(PasswordText.Text))
            {
                ButtonSubmit.IsEnabled = true;
            }
        }

        private void PasswordText_OnTextChanged(object sender, EventArgs e)
        {
            var isPasswordEmpty = string.IsNullOrEmpty(PasswordText.Text);
            if (isPasswordEmpty)
            {
                ButtonSubmit.IsEnabled = false;
                PasswordText.AssistiveText = "Field is required";
                return;
            }

            PasswordText.AssistiveText = "";

            if (!string.IsNullOrEmpty(LoginText.Text))
            {
                ButtonSubmit.IsEnabled = true;
            }
        }

        private async void RedirectToSignUp_Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage(), false);
        }
    }
}
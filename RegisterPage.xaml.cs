namespace pizzaApplication;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}
    private async void OnRegisterClickedAsync(object sender, EventArgs e)

    {
        if (!string.IsNullOrEmpty(password.Text) && !string.IsNullOrEmpty(passwordConfirm.Text) && !string.IsNullOrEmpty(usernameReg.Text))
        {
            if (password.Text == passwordConfirm.Text)
            {
                await DisplayAlert("Registration Success", "You are now registered.", "OK");

            }
            else {
                await DisplayAlert("Registration Error", "Passwords do not match.", "OK");
                return;
            }
        }
        else 
        {
            await DisplayAlert("Registration Error", "Information if not correct.", "OK");
            return;
        } 
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SignInPage());
    }
}
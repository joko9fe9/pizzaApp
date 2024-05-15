namespace pizzaApplication;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
	}
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        try
        {
            if (!string.IsNullOrEmpty(usernameEntry.Text) && !string.IsNullOrEmpty(passwordEntry.Text))
            {
                await DisplayAlert("Login Success", "You are logged in!", "OK");
            }
            else
            {
                await DisplayAlert("Login Failed", "Incorrect username or password.", "OK");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("lox");
        }

    }

    private async void OnLabelTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }
}
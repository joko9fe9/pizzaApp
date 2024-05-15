namespace pizzaApplication
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            carouselView.ItemsSource = new List<CarouselData>
        {
            new CarouselData("pizza1.png", "Classic Flavors,\nEnjoy the timeless tastes of traditional toppings."),
            new CarouselData("pizza2.png", "Cheese Overload,\nExperience the bliss of extra cheese melting in your mouth."),
            new CarouselData("pizza3.png", "Spicy Delight,\nSpice up your life with a slice of our hot and spicy pizza.")
        };
        }
        public class CarouselData
        {
            public string ImageUrl { get; set; }
            public string Text { get; set; }

            public CarouselData(string imageUrl, string text)
            {
                ImageUrl = imageUrl;
                Text = text;
            }
        }
        private async void SignInClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignInPage());
        }

        private async void RegisterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}

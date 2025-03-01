namespace gymBuddy
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Hello", "Let's set up your gym schedule!", "Just kinding..");
        }
        private async void GoToGymPageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GymPage());
        }

        private async void GoToHomePageClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void GoToSettingsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }
    }

}

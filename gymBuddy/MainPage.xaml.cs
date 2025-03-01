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
            await DisplayAlert("Welcome!", "Let's set up your gym schedule!", "OK");
        }
    }

}

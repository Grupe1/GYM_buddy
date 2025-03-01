namespace gymBuddy;

public partial class GymPage : ContentPage
{
	public GymPage()
	{
		InitializeComponent();
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
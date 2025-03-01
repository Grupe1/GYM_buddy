namespace gymBuddy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var mainPage = new MainPage();
            var navigationPage = new NavigationPage(mainPage);
            return new Window(navigationPage);
        }
    }
}
namespace Precub_Oana_app
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            await Navigation.PushAsync(new LoginPage());
        }
        //private async void OnLoginClicked(object sender, EventArgs e)
        //{
            // Navighează către pagina de autentificare
           // await Navigation.PushAsync(new LoginPage());
        //
        //}
    }

}

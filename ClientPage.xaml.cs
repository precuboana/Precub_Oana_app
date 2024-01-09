namespace Precub_Oana_app;
using Precub_Oana_app.Models;

public partial class ClientPage : ContentPage
{
	public ClientPage()
	{
		InitializeComponent();
        LoadClienti();
    }
    private async void LoadClienti()
    {
        ClientiListView.ItemsSource = await App.Database.GetClientiAsync();
    }

    private async void OnSaveClientClicked(object sender, EventArgs e)
    {
        var client = new Client
        {
            Nume = NumeClientEntry.Text,
            Email = EmailClientEntry.Text
        };
        await App.Database.SaveClientAsync(client);
        LoadClienti();
    }
}
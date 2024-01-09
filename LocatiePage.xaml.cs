namespace Precub_Oana_app;
using Precub_Oana_app.Models;

public partial class LocatiePage : ContentPage
{
	public LocatiePage()
	{
		InitializeComponent();
        LoadLocatii();
    }
    private async void LoadLocatii()
    {
        LocatiiListView.ItemsSource = await App.Database.GetLocatiiAsync();
    }
    private async void OnSaveLocatieClicked(object sender, EventArgs e)
    {
        var locatie = new Locatie
        {
            Nume = NumeLocatieEntry.Text,
            Adresa = AdresaLocatieEntry.Text
        };
        await App.Database.SaveLocatieAsync(locatie);
        LoadLocatii();
    }
}
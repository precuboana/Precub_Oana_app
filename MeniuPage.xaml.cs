namespace Precub_Oana_app;
using Precub_Oana_app.Models;

public partial class MeniuPage : ContentPage
{
	public MeniuPage()
	{
		InitializeComponent();
        LoadMeniuri();
    }
    private async void LoadMeniuri()
    {
        MeniuriListView.ItemsSource = await App.Database.GetMeniuriAsync();
    }
    private async void OnSaveMeniuClicked(object sender, EventArgs e)
    {
        var meniu = new Meniu
        {
            Denumire = DenumireMeniuEntry.Text,
            Pret = double.Parse(PretMeniuEntry.Text)
        };
        await App.Database.SaveMeniuAsync(meniu);
        LoadMeniuri();
    }
}
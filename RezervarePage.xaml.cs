namespace Precub_Oana_app;
using Precub_Oana_app.Models;

public partial class RezervarePage : ContentPage
{
	public RezervarePage()
	{
		InitializeComponent();
        LoadRezervari();
    }

	private async void LoadRezervari()
	{
        RezervariListView.ItemsSource = await App.Database.GetRezervariAsync();
    }
	private async void OnSaveRezervareClicked(object sender, EventArgs e)
	{
        var rezervare = new Rezervare
        {
            DataRezervarii = DateTime.Parse(DataRezervariiEntry.Text),
            OraRezervarii = OraRezervariiEntry.Text,
           // ClientID = int.Parse(ClientIdEntry.Text),
            //LocatieID = int.Parse(LocatieIdEntry.Text)
        };

        await App.Database.SaveRezervareAsync(rezervare);
        LoadRezervari();

    }
}
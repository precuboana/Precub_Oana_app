namespace Precub_Oana_app;
using Precub_Oana_app.Models;

public partial class CategoriePage : ContentPage
{
	public CategoriePage()
	{
		InitializeComponent();
        LoadCategorii();

    }
    private async void LoadCategorii()
    {
        CategoriiListView.ItemsSource = await App.Database.GetCategoriiAsync();
    }
    private async void OnSaveCategorieClicked(object sender, EventArgs e)
    {
        var categorie = new Categorie
        {
            Nume = NumeCategorieEntry.Text
        };
        await App.Database.SaveCategorieAsync(categorie);
        LoadCategorii();
    }
}
namespace Precub_Oana_app;
using Precub_Oana_app.Models;
using Precub_Oana_app.Data;
using System.Text;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

	private async void OnLoginClicked(object sender, EventArgs e)
	{
		
        var hashedPassword = HashPassword(PasswordEntry.Text);
        var utilizator = new Utilizator
        {
            NumeUtilizator = UsernameEntry.Text,
            Parola = hashedPassword
        };
        await App.Database.SaveUtilizatorAsync(utilizator);
        await DisplayAlert("Inregistrare", "Inregistrare reusita!", "ok");
        await Navigation.PopAsync();

    }
    private string HashPassword(string password)
    {
        using (var sha256 = System.Security.Cryptography.SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            var builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("2x"));
            }
            return builder.ToString();
        }
    }
}

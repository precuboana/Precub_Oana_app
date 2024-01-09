namespace Precub_Oana_app;
using Precub_Oana_app.Models;
using Precub_Oana_app.Data;
using System.Text;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

	private async void OnRegisterClicked(object sender, EventArgs e)
	{
        var utilizator = await App.Database.GetUtilizatorAsync(UsernameEntry.Text);
        if (utilizator != null && utilizator.Parola == HashPassword(PasswordEntry.Text))
        { 
        App.IsUserLoggedIn = true;
        Application.Current.MainPage = new MainPage();
        }
        else
        {
       await DisplayAlert("Eroare", "Numele de utilizator sau parola sunt incorecte", "ok");
        }
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
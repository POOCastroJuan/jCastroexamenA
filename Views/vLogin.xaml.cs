using Microsoft.Win32;

namespace jCastroexamenA.Views;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}
    private async void OnLoginClicked(object sender, EventArgs e)
    {
              var users = new Dictionary<string, string>
            {
                { "estudiante2025", "moviles" },
                { "uisrael", "2025" },
                { "sistemas", "2025_1" }
            };

        if (users.ContainsKey(usernameEntry.Text) && users[usernameEntry.Text] == passwordEntry.Text)
        {
           
            await Navigation.PushAsync(new vRegistro(usernameEntry.Text));
        }
        else
        {
            
            await DisplayAlert("Error", "Datos incorrectos", "OK");
        }
    }

    private async void OnAboutClicked(object sender, EventArgs e)
    {
        
        await DisplayAlert("Acerca de", "Este sofware fue creado por Juan Castro", "OK");
    }
}
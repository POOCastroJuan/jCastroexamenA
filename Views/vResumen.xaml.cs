namespace jCastroexamenA.Views;

public partial class vResumen : ContentPage
{
	public vResumen()
        {
            InitializeComponent();
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
}
namespace jCastroexamenA.Views;

public partial class vRegistro : ContentPage
{
    public string Usuario { get; set; }

    public vRegistro(string usuario)
    {
        InitializeComponent();
        BindingContext = this;
        Usuario = usuario;
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        double amount = double.Parse(amountEntry.Text);
        double initialAmount = amount * 0.15;
        double remainingAmount = amount - initialAmount;
        double monthlyPayment = (remainingAmount * 1.05) / 3;
        monthlyFeeLabel.Text = $"Cuota Mensual: {monthlyPayment:C}";
    }

    private async void OnSummaryClicked(object sender, EventArgs e)
    {
        
        await Navigation.PushAsync(new vResumen());
    }
}
namespace Crossolution.Views;

public partial class Cadastro : ContentPage
{
	public Cadastro()
	{
		InitializeComponent();
	}

    private async void SemaforoClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Login));
    }
}
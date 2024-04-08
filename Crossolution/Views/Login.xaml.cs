namespace Crossolution.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void EntryButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Semaforos));
    }
}
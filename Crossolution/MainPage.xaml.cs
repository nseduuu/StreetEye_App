using Crossolution.Views;

namespace Crossolution
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void CadastroClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Cadastro));
        }

        private async void LoginClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Login));
        }

    }

}

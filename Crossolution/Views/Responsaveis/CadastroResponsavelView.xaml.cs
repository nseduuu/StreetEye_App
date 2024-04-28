using Crossolution.ViewModels.Responsaveis;

namespace Crossolution.Views.Responsaveis;

public partial class CadastroResponsavelView : ContentPage
{
    ResponsavelViewModel viewModel;

    public CadastroResponsavelView()
    {
        InitializeComponent();
        viewModel = new ResponsavelViewModel();
        BindingContext = viewModel;
    }
}
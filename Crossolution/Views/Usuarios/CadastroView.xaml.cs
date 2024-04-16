using Crossolution.ViewModels.Usuarios;

namespace Crossolution.Views.Usuarios;

public partial class CadastroView : ContentPage
{
    UsuarioViewModel usuarioViewModel;

    public CadastroView()
    {
        InitializeComponent();

        usuarioViewModel = new UsuarioViewModel();
        BindingContext = usuarioViewModel;

    }
}
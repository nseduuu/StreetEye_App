using Crossolution.ViewModels.Usuarios;

namespace Crossolution.Views.Usuarios;

public partial class ViewEntrada : ContentPage
{
    UsuarioViewModel usuarioViewModel;
    public ViewEntrada()
	{
		InitializeComponent();

        usuarioViewModel = new UsuarioViewModel();
        BindingContext = usuarioViewModel;
    }
}
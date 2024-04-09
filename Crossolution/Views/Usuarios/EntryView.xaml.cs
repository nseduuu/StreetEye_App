using Crossolution.ViewModels.Usuarios;

namespace Crossolution.Views.Usuarios;

public partial class EntryView : ContentPage
{
    UsuarioViewModel usuarioViewModel;
    public EntryView()
	{
		InitializeComponent();

        usuarioViewModel = new UsuarioViewModel();
        BindingContext = usuarioViewModel;
    }
}
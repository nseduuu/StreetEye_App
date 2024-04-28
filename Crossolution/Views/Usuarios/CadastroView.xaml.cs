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

    private void OnDateEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string newText = e.NewTextValue;
        if (newText.Length > 2 && newText[2] != '/')
        {
            newText = newText.Insert(2, "/");
        }

        if (newText.Length > 5 && newText[5] != '/')
        {
            newText = newText.Insert(5, "/");
        }

        dateEntry.CursorPosition = newText.Length;
        ((Entry)sender).Text = newText;
    }

}
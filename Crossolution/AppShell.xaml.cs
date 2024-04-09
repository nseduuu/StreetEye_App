using Crossolution.Models;
using Crossolution.Views;

namespace Crossolution
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.Usuarios.CadastroView), typeof(Views.Usuarios.CadastroView));
            Routing.RegisterRoute(nameof(Views.Usuarios.LoginView), typeof(Views.Usuarios.LoginView));
        }
    }
}

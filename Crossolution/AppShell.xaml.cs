using Crossolution.Models;
using Crossolution.Views;

namespace Crossolution
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Cadastro), typeof(Cadastro));
            Routing.RegisterRoute(nameof(Login), typeof(Login));
            Routing.RegisterRoute(nameof(Semaforos), typeof(Semaforos));
        }
    }
}

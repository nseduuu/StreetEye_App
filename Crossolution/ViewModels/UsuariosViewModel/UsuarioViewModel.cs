using Crossolution.Services.Usuarios;
using System.Windows.Input;

namespace Crossolution.ViewModels.UsuariosViewModel
{
    public class UsuarioViewModel : BaseViewModel
    {
        private UsuarioService uService;

        #region Commands
        public ICommand RegistrarCommand { get; set; }
        public ICommand AutenticarCommand { get; set; }
        #endregion

        #region AtributosPropriedades
        private string login = string.Empty;
        private string senha = string.Empty;
        #endregion

        public string Login
        {
            get => login;
            set
            {
                login = value;
                OnPropertyChanged(Login);
            }
        }

        public string Senha
        {
            get => senha;
            set
            {
                senha = value;
                OnPropertyChanged(Senha);
            }
        }
    }
}

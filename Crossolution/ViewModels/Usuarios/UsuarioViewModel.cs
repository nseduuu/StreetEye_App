using Crossolution.Models;
using Crossolution.Services.Usuarios;
using System.Windows.Input;

namespace Crossolution.ViewModels.Usuarios
{
    public class UsuarioViewModel : BaseViewModel
    {
        //ctor + TAB + TAB: Atalho para criar o construtor
        public UsuarioViewModel()
        {
            uService = new UsuarioService();
            InicializarCommands();
            _ = RegistrarUsuario();
        }

        private UsuarioService uService;
        public ICommand AutenticarCommand { get; set; }
        public ICommand RegistrarCommand { get; set; }
        public ICommand DirecionarCadastroCommand { get; set; }

        public void InicializarCommands()
        {
            AutenticarCommand = new Command(async () => await AutenticarUsuario());
            RegistrarCommand = new Command(async () => await RegistrarUsuario());
            DirecionarCadastroCommand = new Command(async () => await DirecionarParaCadastro());
        }


        #region AtributosPropriedades
        //usuario
        private string login = string.Empty;
        private string senha = string.Empty;
        //utilizador
        private string nome = string.Empty;
        private DateTime data;
        private string telefone = string.Empty;
        private string endereco = string.Empty;
        private string numeroEndereco = string.Empty;
        private string complemento = string.Empty;
        private string bairro = string.Empty;
        private string cidade = string.Empty;
        private string uf = string.Empty;
        private string cep = string.Empty;

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

        public string Nome 
        { 
            get => nome;
            set
            {
                nome = value;
                OnPropertyChanged(Nome);
            }
        }

        public DateTime Data 
        { 
            get => data;
            set
            {
                data = value;
                OnPropertyChanged(Data.ToString());
            }
        }

        public string Telefone 
        { 
            get => telefone;
            set
            {
                telefone = value;
                OnPropertyChanged(Telefone);
            }
        }

        public string Endereco 
        { 
            get => endereco;
            set
            {
                endereco = value;
                OnPropertyChanged(Endereco);
            }
        }

        public string NumeroEndereco 
        { 
            get => numeroEndereco;
            set
            {
                numeroEndereco = value;
                OnPropertyChanged(NumeroEndereco);
            }
        }

        public string Complemento 
        { 
            get => complemento;
            set
            {
                complemento = value;
                OnPropertyChanged(Complemento);
            }
        }

        public string Bairro
        {
            get => bairro;
            set
            {
                bairro = value;
                OnPropertyChanged(Bairro);
            }
        }

        public string Cidade 
        { 
            get => cidade;
            set
            {
                cidade = value;
                OnPropertyChanged(Cidade);
            }
        }

        public string Uf 
        { 
            get => uf;
            set
            {
                uf = value;
                OnPropertyChanged(Uf);
            }
        }

        public string Cep 
        { 
            get => cep;
            set
            {
                cep = value;
                OnPropertyChanged(Cep);
            }
        }

        #endregion

        #region Metodos
        public async Task AutenticarUsuario()//Método para autenticar um usuário     
        {
            try
            {
                Usuario u = new Usuario();
                u.Email = Login;
                u.Password = Senha;

                Usuario uAutenticado = await uService.PostAutenticarUsuarioAsync(u);

                if (!string.IsNullOrEmpty(uAutenticado.Token))
                {
                    string mensagem = $"Bem-vindo(a) {uAutenticado.Utilizador.Nome}.";

                    //Guardando dados do usuário para uso futuro
                    Preferences.Set("Email", uAutenticado.Email);
                    Preferences.Set("UsuarioNome", uAutenticado.Utilizador.Nome);
                    Preferences.Set("UsuarioToken", uAutenticado.Token);

                    await Application.Current.MainPage.DisplayAlert("Informação", mensagem, "Ok");

                    Application.Current.MainPage = new AppShell();
                }
                else
                {
                    await Application.Current.MainPage
                        .DisplayAlert("Informação", "Dados incorretos :(", "Ok");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage
                    .DisplayAlert("Informação", ex.Message + " Detalhes: " + ex.InnerException, "Ok");
            }
        }
        public async Task RegistrarUsuario()//Método para registrar um usuário     
        {
            try
            {
                Usuario u = new Usuario();
                Utilizador ut = new Utilizador();

                u.Email = Login;
                u.Password = Senha;
                ut.Nome = "Ana";
                ut.DataNascimento = DateTime.Parse("2003-08-02");
                ut.Telefone = "994774729";
                ut.Endereco = "Rua";
                ut.NumeroEndereco = "123";
                ut.Complemento = "";
                ut.Bairro = "vila";
                ut.Cidade = "são";
                ut.UF = "SP";
                ut.CEP = "02229070";

                u.Utilizador = ut;

                Usuario uRegistrado = await uService.PostRegistrarUsuarioAsync(u);

                if (uRegistrado.IdUsuario != 0)
                {
                    string mensagem = $"Usuário {uRegistrado.Utilizador.Nome} registrado com sucesso.";
                    await Application.Current.MainPage.DisplayAlert("Informação", mensagem, "Ok");

                    await Application.Current.MainPage
                        .Navigation.PopAsync();//Remove a página da pilha de visualização
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage
                    .DisplayAlert("Informação", ex.Message + " Detalhes: " + ex.InnerException, "Ok");
            }
        }

        public async Task DirecionarParaLogin()//Método para exibição da view de Login      
        {
            try
            {
                await Application.Current.MainPage.
                    Navigation.PushAsync(new Views.Usuarios.LoginView());
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage
                    .DisplayAlert("Informação", ex.Message + " Detalhes: " + ex.InnerException, "Ok");
            }
        }

        public async Task DirecionarParaCadastro()//Método para exibição da view de Cadastro      
        {
            try
            {
                await Application.Current.MainPage.
                    Navigation.PushAsync(new Views.Usuarios.CadastroView());
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage
                    .DisplayAlert("Informação", ex.Message + " Detalhes: " + ex.InnerException, "Ok");
            }
        }
        #endregion

    }
}

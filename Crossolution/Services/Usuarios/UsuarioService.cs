using Crossolution.Models;
using Crossolution.ViewModels;
using System.Windows.Input;

namespace Crossolution.Services.Usuarios
{
    public class UsuarioService : Request
    {
        private readonly Request _request;

        private const string apiUrlBase = "http://myprojects.somee.com/StreetEye/Usuarios";

        //ctor + TAB: Atalho para criar um construtor
        public UsuarioService()
        {
            _request = new Request();
        }

        public async Task<Usuario> PostRegistrarUsuarioAsync(Usuario u)
        {
            string urlComplementar = "/Registrar";
            u.IdUsuario = await _request.PostReturnIntAsync(apiUrlBase + urlComplementar, u, string.Empty);

            return u;
        }

        public async Task<Usuario> PostAutenticarUsuarioAsync(Usuario u)
        {
            string urlComplementar = "/Autenticar";
            u = await _request.PostAsync(apiUrlBase + urlComplementar, u, string.Empty);

            return u;
        }





    }
}

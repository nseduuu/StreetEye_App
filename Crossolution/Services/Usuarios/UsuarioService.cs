using Crossolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossolution.Services.Usuarios
{
    public class UsuarioService : Request
    {
        private readonly Request _request;
        private const string apiUrLBase = "http://xyz.somee.com/CrossolutionApi/Usuarios";

        //ctor + TAB -> atalho para contrutor
        public UsuarioService()
        {
            _request = new Request();
        }

        public async Task<Usuario> PostRegistrarUsuarioAsync(Usuario u)
        {
            string urlComplementar = "/Registrar";
            u.IdUsuario = await _request.PostReturnIntAsync(apiUrLBase + urlComplementar, u);

            return u;
        }

        public async Task<Usuario> PostAutenticarUsuarioAsync(Usuario u)
        {
            string urlComplementar = "/Autenticar";
            u = await _request.PostAsync(apiUrLBase + urlComplementar, u, string.Empty);

            return u;
        }

    }
}

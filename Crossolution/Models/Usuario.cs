using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossolution.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdUtilizador { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        // public string PasswordSalt { get; set; } = string.Empty;
        // public string PasswordHash { get; set; } = string.Empty;

        public string Token { get; set; } = string.Empty;
        public byte[]? Foto { get; set; }

        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public Utilizador Utilizador { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossolution.Models
{
    public class Utilizador : Usuario
    { 
        public int IdTipoUtilizador { get; set; }
        public string DsTipoUtilizador { get; set; } = string.Empty;
        public string NmUtilizador { get; set; } = string.Empty;
        public DateTime DnUtilizador  { get; set; }
        public int ClUtilizador { get; set; }
        public string EnUtilizador { get; set; } = string.Empty;
        public string NeUtilizador { get; set; } = string.Empty;
        public string CmUtilizador { get; set; } = string.Empty;
        public string BaUtilizador { get; set; } = string.Empty;
        public string CiUtilizador { get; set; } = string.Empty;
        public string UfUtilizador { get; set; } = string.Empty;
        public string CeUtilizador { get; set; } = string.Empty;
        public string LtUtilizador { get; set; } = string.Empty;
        public string Lgilizador { get; set; } = string.Empty;

    }
}

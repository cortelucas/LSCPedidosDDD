using LSCPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSCPedidos.Domain.Entities
{
    public class Imagem : BaseDomain
    {        
        public string Nome { get; set; }
        public string NomeDoArquivo { get; set; }
        public bool Principal { get; set; }
    }
}

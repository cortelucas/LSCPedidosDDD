using LSCPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSCPedidos.Domain.Entities
{
    public class CategoriaProduto : BaseDomain, IExibivel
    {        
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}

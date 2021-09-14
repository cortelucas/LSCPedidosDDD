using LSCPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSCPedidos.Domain.Entities
{
    public class Combo : BaseDomain, IExibivel
    {        
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public int IDImagem { get; set; }
        public virtual Imagem Imagem { get; set; }

        public virtual List<Produto> Produtos { get; set; }

        public bool Ativo { get; set; }
    }
}

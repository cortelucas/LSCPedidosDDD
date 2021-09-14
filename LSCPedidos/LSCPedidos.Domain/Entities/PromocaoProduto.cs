using LSCPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSCPedidos.Domain.Entities
{
    public class PromocaoProduto : BaseDomain, IExibivel
    {        
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public int IDImagem { get; set; }
        public virtual Imagem Imagem { get; set; }

        public int IDProduto { get; set; }
        public virtual Produto Produto { get; set; }

        public bool Ativo { get; set; }
    }
}

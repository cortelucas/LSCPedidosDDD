using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSCPedidos.Domain.Entities
{
    public class ProdutoPedido : BaseDomain
    {
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public int IDProduto { get; set; }
        public virtual Produto Produto { get; set; }

        public int IDPedido { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}

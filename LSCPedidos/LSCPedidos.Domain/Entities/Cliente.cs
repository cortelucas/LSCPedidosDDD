using LSCPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSCPedidos.Domain.Entities
{
    public class Cliente : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public int IDEndereco { get; set; }
        public virtual Endereco Endereco { get; set; }

        public bool Ativo { get; set; }
    }
}

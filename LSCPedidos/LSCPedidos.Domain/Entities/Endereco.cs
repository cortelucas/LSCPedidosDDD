using LSCPedidos.Domain.Enums;
using LSCPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSCPedidos.Domain.Entities
{
    class Endereco : BaseDomain
    {        
        public TipoEnderecoEnum Tipo { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }

        public int IDCidade { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSCPedidos.Domain.Entities
{
    public abstract class BaseDomain
    {
        public int ID { get; set; }
        public DateTime CriadoEm { get; set; }

    }
}

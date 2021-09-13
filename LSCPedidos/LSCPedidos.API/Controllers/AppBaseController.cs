using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSCPedidos.API.Controllers
{
    public class AppBaseController : ControllerBase
    {
        protected readonly IServiceProvider _ServiceProvider;

        public AppBaseController(IServiceProvider serviceProvider)
        {
            _ServiceProvider = serviceProvider;
        }
    }
}

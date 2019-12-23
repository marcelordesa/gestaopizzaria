using System;
using System.Collections.Generic;
using System.Text;

namespace pizza_domains.Contracts.Services
{
    public interface IService
    {
        object GetPedido(object pedido);
    }
}

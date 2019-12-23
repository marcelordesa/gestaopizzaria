using pizza_domains.Contracts.Repositories;
using pizza_domains.Contracts.Services;
using pizza_domains.Entities;
using pizza_infrastructure.Repository;
using pizza_models;
using pizza_repositoryFactory;

namespace pizza_services
{
    public class PizzaService : IService
    {
        private IRepository repositoryTamanho = RepositoryFactory.GetInstanciaRepositorio<TamanhoRepository>();
        private IRepository repositorySabor = RepositoryFactory.GetInstanciaRepositorio<SaborRepository>();
        public object GetPedido(object pedido)
        {
            var _pedido = (PedidoPizzaModel)pedido;
            Pizza pizza = new Pizza();
            pizza.Tamanho = new Tamanho(repositoryTamanho);
            pizza.Tamanho.Id = _pedido.Tamanho;
            pizza.Sabor = new Sabor(repositorySabor);
            pizza.Sabor.Id = _pedido.Sabor;

            RetornoPedidoModel model = new RetornoPedidoModel();
            model.Cliente = _pedido.Cliente;
            model.Sabor = pizza.Sabor.Description;
            model.Tamanho = pizza.Tamanho.Description;
            model.Valor = pizza.Tamanho.Price;
            model.TempoDuracao = pizza.Tamanho.PreparationTime + pizza.Sabor.PreparationTime;

            return model;
        }
    }
}
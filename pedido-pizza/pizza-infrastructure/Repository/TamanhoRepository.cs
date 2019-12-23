using pizza_domains.Contracts.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace pizza_infrastructure.Repository
{
    public class TamanhoRepository : IRepository
    {
        public IEnumerable<object> GetAll()
        {
            return PizzaContext.Instance.Tamanhos();
        }

        public object GetOne(int id)
        {
            return PizzaContext.Instance.Tamanhos().Where(t => t.Id == id).FirstOrDefault();
        }
    }
}
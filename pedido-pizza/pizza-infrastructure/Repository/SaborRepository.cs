using pizza_domains.Contracts.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace pizza_infrastructure.Repository
{
    public class SaborRepository : IRepository
    {
        public IEnumerable<object> GetAll()
        {
            return PizzaContext.Instance.Sabores();
        }

        public object GetOne(int id)
        {
            return PizzaContext.Instance.Sabores().Where(t => t.Id == id).FirstOrDefault();
        }
    }
}
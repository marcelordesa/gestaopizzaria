using System.Collections.Generic;

namespace pizza_domains.Contracts.Repositories
{
    public interface IRepository
    {
        IEnumerable<object> GetAll();
        object GetOne(int id);
    }
}
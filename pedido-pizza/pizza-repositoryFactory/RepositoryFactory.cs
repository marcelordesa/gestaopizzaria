using pizza_domains.Contracts.Repositories;

namespace pizza_repositoryFactory
{
    public class RepositoryFactory
    {
        public static IRepository GetInstanciaRepositorio<T>() where T : IRepository, new()
        {
            return new T();
        }
    }
}
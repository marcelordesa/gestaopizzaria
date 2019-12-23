using pizza_domains.Contracts.Services;

namespace pizza_serviceFactory
{
    public class ServiceFactory
    {
        public static IService GetInstanciaServico<T>() where T : IService, new()
        {
            return new T();
        }
    }
}
using pizza_domains.Contracts.Repositories;

namespace pizza_domains.Entities
{
    public class Tamanho
    {
        private int id;
        public int Id 
        {
            get { return id; }
            set 
            {
                var tamanho = (Tamanho)this.Repository.GetOne(value);
                this.Description = tamanho.Description;
                this.PreparationTime = tamanho.PreparationTime;
                this.Price = tamanho.Price;
            }
        }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int PreparationTime { get; set; }

        private IRepository Repository;

        public Tamanho(IRepository _repository)
        {
            this.Repository = _repository;
        }

        public Tamanho() { }
    }
}
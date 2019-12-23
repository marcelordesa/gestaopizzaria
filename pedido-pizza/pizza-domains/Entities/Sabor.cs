using pizza_domains.Contracts.Repositories;

namespace pizza_domains.Entities
{
    public class Sabor
    {
        private int id;
        public int Id 
        {
            get { return id; }
            set 
            {
                var sabor = (Sabor)this.Repository.GetOne(value);
                this.Description = sabor.Description;
                this.PreparationTime = sabor.PreparationTime;
            }
        }
        public string Description { get; set; }
        public int PreparationTime { get; set; }

        private IRepository Repository;

        public Sabor(IRepository _repository)
        {
            this.Repository = _repository;
        }

        public Sabor(){}
    }
}

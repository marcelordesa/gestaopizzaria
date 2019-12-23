using pizza_domains.Entities;
using System.Collections.Generic;

namespace pizza_infrastructure
{
    public class PizzaContext
    {
        private static PizzaContext instance;
        private static readonly object padlock = new object();

        public static PizzaContext Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new PizzaContext();
                        }
                    }
                }
                return instance;
            }
        }

        public List<Tamanho> Tamanhos()
        {
            return new List<Tamanho> 
            {
                new Tamanho {
                    Id = 1,
                    Description = "Pequena",
                    Price = 20.00M,
                    PreparationTime = 15
                },

                new Tamanho {
                    Id = 2,
                    Description = "Média",
                    Price = 30.00M,
                    PreparationTime = 20
                },

                new Tamanho {
                    Id = 3,
                    Description = "Grande",
                    Price = 40.00M,
                    PreparationTime = 25
                }
            };
        }

        public List<Sabor> Sabores()
        {
            return new List<Sabor>
            {
                new Sabor {
                    Id = 1,
                    Description = "Calabresa",
                    PreparationTime = 0
                },

                new Sabor {
                    Id = 2,
                    Description = "Marguerita",
                    PreparationTime = 0
                },

                new Sabor {
                    Id = 3,
                    Description = "Portuguesa",
                    PreparationTime = 5
                }
            };
        }
    }
}
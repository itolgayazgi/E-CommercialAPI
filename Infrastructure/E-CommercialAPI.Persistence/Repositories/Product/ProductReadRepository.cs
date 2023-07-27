using E_CommercialAPI.Application.Repositories;
using E_CommercialAPI.Domain.Entities;
using E_CommercialAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommercialAPI.Persistence.Repositories
{
    public class ProductReadRepository : ReadRepository<Product> , IProductReadRepository
    {
        public ProductReadRepository(E_CommercialAPIDbContext context) : base(context)
        {
            
        }
    }
}

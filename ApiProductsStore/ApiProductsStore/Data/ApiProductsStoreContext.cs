using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApiProductsStore.Models
{
    public class ApiProductsStoreContext : DbContext
    {
        public ApiProductsStoreContext (DbContextOptions<ApiProductsStoreContext> options)
            : base(options)
        {
        }

        public DbSet<ApiProductsStore.Models.Product> Product { get; set; }
    }
}

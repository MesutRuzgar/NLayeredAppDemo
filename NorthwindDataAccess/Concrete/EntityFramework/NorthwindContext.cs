using NorthwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDataAccess.Concrete.EntityFramework
{
    class NorthwindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}

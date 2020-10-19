using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpredio.Entities.Concrete;

namespace Xpredio.DataAccessLayer.Concrete.EntityFramework
{
   public class XpredioContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

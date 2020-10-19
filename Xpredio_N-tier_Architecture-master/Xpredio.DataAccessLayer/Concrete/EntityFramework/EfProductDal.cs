using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xpredio.DataAccessLayer.Abstract;
using Xpredio.Entities.Concrete;

namespace Xpredio.DataAccessLayer.Concrete.EntityFramework
{
    public class EfProductDal:IProductDal
    {
        public List<Product> GetAll()
        {
            using (XpredioContext context = new XpredioContext())
            {
                return context.Products.ToList();
            }
        }

        public Product Get(int id)
        {
            using (XpredioContext context = new XpredioContext())
            {
                return context.Products.SingleOrDefault(x => x.ProductId == id);
            }
        }

        public void Add(Product product)
        {
            using (XpredioContext context = new XpredioContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {

        }
        public void Delete(Product product)
        {

        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (XpredioContext context = new XpredioContext())
            {
                return context.Products.ToList();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (XpredioContext context = new XpredioContext())
            {
                return context.Products.SingleOrDefault(filter);
            }
        }
    }
}

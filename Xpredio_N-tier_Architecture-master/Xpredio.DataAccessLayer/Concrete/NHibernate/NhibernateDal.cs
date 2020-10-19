using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpredio.DataAccessLayer.Abstract;
using Xpredio.Entities.Concrete;

namespace Xpredio.DataAccessLayer.Concrete.NHibernate
{
   public class NhibernateDal:IProductDal
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

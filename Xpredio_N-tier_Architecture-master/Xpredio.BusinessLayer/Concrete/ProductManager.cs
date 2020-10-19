using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpredio.BusinessLayer.Abstract;
using Xpredio.DataAccessLayer.Abstract;
using Xpredio.Entities.Concrete;

namespace Xpredio.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}

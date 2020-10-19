using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xpredio.Entities.Concrete;

namespace Xpredio.BusinessLayer.Abstract
{
   public interface IProductService
   {
       List<Product> GetAll();

   }
}

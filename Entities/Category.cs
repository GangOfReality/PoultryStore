using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entities
{
    class Category : ICategory
    {
        public void AddProduct()
        {
            throw new NotImplementedException();
        }

        public IProduct GetProductByName(string productName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IProduct> GetProducts()
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct()
        {
            throw new NotImplementedException();
        }
    }
}

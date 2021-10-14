using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entities
{
    interface ICategory
    {
        void AddProduct();

        void RemoveProduct();

        IProduct GetProductByName(string productName);

        IEnumerable<IProduct> GetProducts();
    }
}

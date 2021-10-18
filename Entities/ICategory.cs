using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface ICategory
    {
        string Name { get; set; }

        string Image { get; set; }

        void AddProduct();

        void RemoveProduct();

        IProduct GetProductByName(string productName);

        IEnumerable<IProduct> GetProducts();
    }
}

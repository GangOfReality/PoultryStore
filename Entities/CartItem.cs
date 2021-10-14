using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CartItem : ICartItem
    {
        private IProduct product;
        private int quantity;

        public int GetSubtotal()
        {
            throw new NotImplementedException();
        }
    }
}

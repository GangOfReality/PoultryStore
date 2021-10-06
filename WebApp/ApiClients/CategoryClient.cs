using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ApiClients
{
    public class CategoryClient
    {
        public async Task<List<CategoryDTO>> ReceiveAllCategories()
        {
            var categoryes = new List<CategoryDTO>();

            categoryes.Add(new CategoryDTO { Label = "Бройлеры", ImageLink = "img/cart-broyler.jpg" });
            categoryes.Add(new CategoryDTO { Label = "Несушки", ImageLink = "img/cart-nesushka.jpg" });
            categoryes.Add(new CategoryDTO { Label = "Яйца", ImageLink = "img/gallery6.jpg" });
            categoryes.Add(new CategoryDTO { Label = "Яйца инкубационные" });

            return categoryes;
        }
    }
}

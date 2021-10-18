using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Models;

namespace DAL.Repositories
{
    class CategoryRepository
    {

        public List<Category> GetAllCategoryes()
        {
            //TODO: It's mock, need to call db. 
            List<Category> categoryes = new()
            {
                new() { Name = "Бройлеры", ImageLink = "img/cart-broyler.jpg" },
                new() { Name = "Несушки", ImageLink = "img/cart-nesushka.jpg" },
                new() { Name = "Яйца", ImageLink = "img/gallery6.jpg" }
            };

            return categoryes;
        }
    }
}

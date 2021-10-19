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

        public List<Category> RetrieveAllCategoryes()
        {
            //Use only once, for creating some test rows in db.
            //CreateTestCategoryes();

            List<Category> categoryes;
            using (ApplicationContext context = new ApplicationContext())
            {
                categoryes = context.Categories.ToList();
            }

            return categoryes;
        }

        private void CreateTestCategoryes()
        {
            List<Category> categoryes = new()
            {
                new() { Name = "Бройлеры", ImageLink = "img/cart-broyler.jpg" },
                new() { Name = "Несушки", ImageLink = "img/cart-nesushka.jpg" },
                new() { Name = "Яйца", ImageLink = "img/gallery6.jpg" }
            };

            using (ApplicationContext context = new ApplicationContext())
            {
                foreach (var cat in categoryes)
                {
                    context.Categories.Add(cat);
                }
                context.SaveChanges();
            }
        }
    }
}

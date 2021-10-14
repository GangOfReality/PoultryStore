using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BusinessLayer.ApiDTO;

namespace BusinessLayer.CustomerUseCases
{
    public interface IWatchCatalogUseCase
    {
        IEnumerable<CategoryDTO> GetCategories();

        IEnumerable<ProductDTO> GetProductsByCategoryId(Guid categoryId);
    }
}

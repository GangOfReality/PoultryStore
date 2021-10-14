using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ApiDTO = BusinessLayer.ApiDTO;

namespace BusinessLayer.Interfaces
{
    public interface IWatchCatalogUseCase
    {
        IEnumerable<ApiDTO::Category> GetCategories();

        IEnumerable<ApiDTO::Product> GetProductsByCategoryId(Guid categoryId);
    }
}

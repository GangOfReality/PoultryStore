using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ApiDTO
{
    public record Category
    {
        public string Name { get; init; }

        public string ImageLink { get; init; }
    }
}

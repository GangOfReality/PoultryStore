using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.WebDTO
{
    public record Category
    {
        public string Name { get; set; }

        public string ImageLink { get; set; }
    }
}

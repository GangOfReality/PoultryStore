using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DalDTO
{
    public record Category
    {
        public string Name { get; set; }

        public string ImageLink { get; set; }
    }
}

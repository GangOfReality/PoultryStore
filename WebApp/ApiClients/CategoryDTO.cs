using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ApiClients
{
    public record CategoryDTO
    {
        public string Label { get; set; }
        public string ImageLink { get; set; }
    }
}

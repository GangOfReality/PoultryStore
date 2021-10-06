using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Landing
{
    public class CarouselViewModel
    {
        public List<CarouselItemViewModel> CarouselItems { get; set; }

        public int ItemsCount 
        { 
            get => CarouselItems.Count; 
        }
    }
}

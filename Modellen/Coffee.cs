using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modellen
{
    public class Coffee
    {
        public int CoffeeId { get; set; }
        public string CoffeeName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Country OriginCountry { get; set; }
        public bool InStock { get; set; }
        public int AmountInStock { get; set; }
        public DateTime FirstAddedToStockDate { get; set; }
        public int ImageId { get; set; }
    }
}

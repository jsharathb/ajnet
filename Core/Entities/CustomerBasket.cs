using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class CustomerBasket
    {
        public CustomerBasket()
        {
        }

        public CustomerBasket(string iD)
        {
            ID = iD;
        }

        public string ID {get; set;}
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
    }
}
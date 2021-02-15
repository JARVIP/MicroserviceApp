using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetRunBasics.Models
{
    public class BasketModel
    {
        public string UserName { get; set; }

        public List<BasketCartItemModel> Items { get; set; } = new List<BasketCartItemModel>();

        public decimal TotalPrice { get; set; }
    }
}

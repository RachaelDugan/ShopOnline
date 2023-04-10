using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Models.Dtos
{
    public class CartItemDto
    {
        public int Id { get; set; } 
        public int ProductId { get; set; }
        public int CartId { get; set; }
        public string? ProdcuctName { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }
        public decimal PriceTotal { get; set;}
        public int Qty { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Dal.Entiti
{
    public class Product
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public decimal OriPrice { get; set; }
        public int Stock { get; set; } //so luong
        public string Note { get; set; } //ghi chu
        public DateTime DateCreated { set; get; }

        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }

        public List<ProductTranslation> ProductTranslations { get; set; }


    }
}

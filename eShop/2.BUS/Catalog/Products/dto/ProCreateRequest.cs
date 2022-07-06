using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.Catalog.Products.dto
{
    public class ProCreateRequest
    {
        public int Id { get; set; } //vì ko để tự tăng nên phải để khổ thế này
        public decimal Price { get; set; }
        public decimal OriPrice { get; set; }
        public int Stock { get; set; } //so luong
        public string Note { get; set; } //ghi chu
        public DateTime DateCreated { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }

        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }
    }
}

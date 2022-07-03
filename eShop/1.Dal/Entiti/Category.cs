using _1.Dal.Entiti.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1.Dal.Entiti
{
    public class Category
    {
        public  int Id { get; set; }    
        public  int SortOder { get; set; }    
        public  bool IsShowOnHome { get; set; }    
        public  int? ParentID { get; set; }    
        public  Status Status { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}

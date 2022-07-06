using _2.BUS.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.Catalog.Products.dto
{
    public class PagingRequets : PagingBase
    {
        public string Keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}

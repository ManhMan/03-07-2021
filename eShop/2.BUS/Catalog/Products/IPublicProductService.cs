using _2.BUS.Catalog.Products.dto;
using _2.BUS.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.Catalog.Products
{
    public interface IPublicProductService
    {
        PagedViewModel<ProViewModel> GetByCategoryId( int categoryId , int pageIndex, int pageSize);
    }
}

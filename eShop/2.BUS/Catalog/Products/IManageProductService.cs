using _2.BUS.Catalog.Products.dto;
using _2.BUS.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.Catalog.Products
{
    public interface IManageProductService
    {
        int Create(ProCreateRequest request);       
        int Update(ProUpdateRequest request);
        
        int Delete(int ProductId);
        void AddViewCount(int ProductId); //trong db không có viewcount
        bool UpdatePrice(int productId, decimal newPrice);

        bool UpdateStock(int productId, int addedQuantity);

        List<ProViewModel> GetAll();
        PagedViewModel<ProViewModel> GetAllPaging(PagingRequets requets);
    }
}

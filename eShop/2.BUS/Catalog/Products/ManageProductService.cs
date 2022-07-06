using _1.Dal.Context;
using _1.Dal.Entiti;
using _2.BUS.Catalog.Products.dto;
using _2.BUS.DTOS;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2.BUS.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private DatabaseContext _context;
        public ManageProductService(DatabaseContext context)
        {
            _context = context;
        }

        public void AddViewCount(int ProductId) //cái này bỏ vì trong db không có viewCount
        {
        }

        public int Create(ProCreateRequest request)
        {
            var product = new Product()
            {
                Id = request.Id,
                Price = request.Price,
                OriPrice = request.OriPrice,
                Stock = request.Stock,
                Note = request.Note,
                DateCreated = DateTime.Now,
                ProductTranslations = new List<ProductTranslation>()
                {
                    new ProductTranslation()
                    {
                        Id = request.Id,
                        Name =  request.Name,
                        Description = request.Description,
                        Details = request.Details,
                        SeoDescription = request.SeoDescription,
                        SeoAlias = request.SeoAlias,
                        SeoTitle = request.SeoTitle,
                        LanguageId = request.LanguageId
                    }
                }
            };
            _context.Products.Add(product);
            return _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public int Delete(int ProductId)
        {
            var product = _context.Products.Find(ProductId);
            if (product == null)
            {
                //báo lỗi không tìm thấy 
            }
            _context.Products.Remove(product);
            return _context.SaveChanges();
        }

        public List<ProViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public PagedViewModel<ProViewModel> GetAllPaging(PagingRequets requets)
        {
            throw new NotImplementedException();
        }

        public int Update(ProUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePrice(int productId, decimal newPrice)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStock(int productId, int addedQuantity)
        {
            throw new NotImplementedException();
        }
    }
}

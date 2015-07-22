using ProductApp.Domain.Models;
using ProductApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Services
{
    public class ProductService : IProductService
    {
        private IGenericRepository _repo;

        public ProductService(IGenericRepository repo)
        {
            _repo = repo;
        }

        public IList<ProductDTO> List()
        {
            return _repo.Query<Product>().Select(p => new ProductDTO
            {
                CategoryName = p.Category.Name,
                Name = p.Name,
                Price = p.Price
            }).ToList();
        }

        public ProductDTO Get(int id)
        {
            var product = _repo.Query<Product>().Where(p => p.Id == id).Select(p => new ProductDTO
            {
                CategoryName = p.Category.Name,
                Name = p.Name,
                Price = p.Price
            }).FirstOrDefault();

            return product;
        }
    }
}

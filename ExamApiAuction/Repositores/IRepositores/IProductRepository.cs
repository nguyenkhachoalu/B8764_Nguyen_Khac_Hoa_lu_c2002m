using ExamApiAuction.Dtos.ProductDto;
using ExamApiAuction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamApiAuction.Repositores.IRepositores
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductReadDto>> GetProductsAsync(CancellationToken cancellationToken);
        Task<Product> GetProductById(int id, CancellationToken cancellationToken);
        Task AddProduct(Product product, CancellationToken cancellationToken);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product );
        Task<IEnumerable<ProductReadDto>> GetProductByName(string name, CancellationToken cancellationToken);
        void Savechange();
    }
}

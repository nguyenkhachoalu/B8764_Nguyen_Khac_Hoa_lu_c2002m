using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExamApiAuction.Dtos.ProductDto;
using ExamApiAuction.Model;
using ExamApiAuction.Repositores.IRepositores;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamApiAuction.Repositores
{
    public class ProductRepository : IProductRepository
    {
        private AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public ProductRepository(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task AddProduct(Product product, CancellationToken cancellationToken)
        {
            await _appDbContext.Products.AddAsync(product, cancellationToken);
        }

        public void DeleteProduct(Product product)
        {
            _appDbContext.Products.Remove(product);
        }

        public async Task<Product> GetProductById(int id, CancellationToken cancellationToken)
        {
            return await _appDbContext.Products.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<IEnumerable<ProductReadDto>> GetProductByName(string name, CancellationToken cancellationToken)
        {
            return await _appDbContext.Products.Where(x => x.Name.ToLower().Contains(name.ToLower()))
                .ProjectTo<ProductReadDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<IEnumerable<ProductReadDto>> GetProductsAsync(CancellationToken cancellationToken)
        {
            return await _appDbContext.Products.ProjectTo<ProductReadDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
        }

        public void Savechange()
        {
            _appDbContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _appDbContext.Products.Update(product);
        }
    }
}

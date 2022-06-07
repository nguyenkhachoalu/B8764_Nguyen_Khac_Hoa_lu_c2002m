using AutoMapper;
using ExamApiAuction.Dtos.ProductDto;
using ExamApiAuction.Model;
using ExamApiAuction.Repositores.IRepositores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamApiAuction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private IMapper _mapper;

        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductAsync(CancellationToken cancellationToken)
        {
            var result = await _productRepository.GetProductsAsync(cancellationToken);
            return await Task.FromResult(Ok(result));
        }
        [HttpGet("{productName}")]
        public async Task<IActionResult> GetProductByName(string productName, CancellationToken cancellationToken)
        {
            var result = await _productRepository.GetProductByName(productName, cancellationToken);
            return await Task.FromResult(Ok(result));
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductCreateDto product, CancellationToken cancellationToken)
        {
            var productModel = _mapper.Map<Product>(product);
            await _productRepository.AddProduct(productModel, cancellationToken);
            _productRepository.Savechange();

            return await Task.FromResult(Ok(productModel));
        }

        [HttpPut("{productId}")]
        public async Task<IActionResult> UpdateProduct(int productId, ProductUpdateDto product, CancellationToken cancellationToken)
        {
            var productResult = await _productRepository.GetProductById(productId, cancellationToken);
            if (productResult == null)
            {
            }

            var productModel = _mapper.Map<Product>(product);
            productModel.Id = productResult.Id;
            _productRepository.UpdateProduct(productModel);
            _productRepository.Savechange();

            return await Task.FromResult(Ok(productModel));
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> DeleteUser(int productId, CancellationToken cancellationToken)
        {
            var productResult = await _productRepository.GetProductById(productId, cancellationToken);
            if (productResult == null)
            {
            }
            _productRepository.DeleteProduct(productResult);
            _productRepository.Savechange();

            return await Task.FromResult(Ok());
        }
    }
}

using AutoMapper;
using ExamApiAuction.Dtos.CategoryDto;
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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        private IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoryAsync(CancellationToken cancellationToken)
        {
            var result = await _categoryRepository.GetCategoresAsync(cancellationToken);
            return await Task.FromResult(Ok(result));
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryCreateDto cate, CancellationToken cancellationToken)
        {
            var cateModel = _mapper.Map<Category>(cate);
            await _categoryRepository.AddCategory(cateModel, cancellationToken);
            _categoryRepository.Savechange();

            return await Task.FromResult(Ok(cateModel));
        }

        [HttpPut("{cateId}")]
        public async Task<IActionResult> UpdateCategory(int cateId, CategoryUpdateDto cate, CancellationToken cancellationToken)
        {
            var cateResult = await _categoryRepository.GetCategoryById(cateId, cancellationToken);
            if (cateResult == null)
            {
            }

            var cateModel = _mapper.Map<Category>(cate);
            cateModel.Id = cateResult.Id;
            _categoryRepository.UpdateCategory(cateModel);
            _categoryRepository.Savechange();

            return await Task.FromResult(Ok(cateModel));
        }

        [HttpDelete("{cateId}")]
        public async Task<IActionResult> DeleteCategory(int cateId, CancellationToken cancellationToken)
        {
            var cateResult = await _categoryRepository.GetCategoryById(cateId, cancellationToken);
            if (cateResult == null)
            {
            }

            _categoryRepository.DeleteCategory(cateResult);
            _categoryRepository.Savechange();

            return await Task.FromResult(Ok());
        }
    }
}

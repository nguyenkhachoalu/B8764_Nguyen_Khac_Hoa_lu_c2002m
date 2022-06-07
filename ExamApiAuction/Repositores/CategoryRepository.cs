using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExamApiAuction.Dtos.CategoryDto;
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
    public class CategoryRepository : ICategoryRepository
    {
        private AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public CategoryRepository(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        public async Task AddCategory(Category category, CancellationToken cancellationToken)
        {
            await _appDbContext.Categories.AddAsync(category, cancellationToken);
        }

        public void DeleteCategory(Category category)
        {
            _appDbContext.Categories.Remove(category);
        }

        public async Task<IEnumerable<CategoryReadDto>> GetCategoresAsync(CancellationToken cancellationToken)
        {
            return await _appDbContext.Categories.ProjectTo<CategoryReadDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
        }

        public async Task<Category> GetCategoryById(int id, CancellationToken cancellationToken)
        {

            return await _appDbContext.Categories.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<IEnumerable<Category>> GetCategoryByName(string name, CancellationToken cancellationToken)
        {
            return await _appDbContext.Categories.Where(x => x.Name.Contains(name)).ToListAsync();
        }

        public void Savechange()
        {
            _appDbContext.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _appDbContext.Categories.Update(category);
        }
     
    }
}

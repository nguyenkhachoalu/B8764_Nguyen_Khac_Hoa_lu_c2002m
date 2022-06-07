using ExamApiAuction.Dtos.CategoryDto;
using ExamApiAuction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamApiAuction.Repositores.IRepositores
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<CategoryReadDto>> GetCategoresAsync(CancellationToken cancellationToken);
        Task<Category> GetCategoryById(int id, CancellationToken cancellationToken);
        Task AddCategory(Category category, CancellationToken cancellationToken);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category );
        void Savechange();
    }
}

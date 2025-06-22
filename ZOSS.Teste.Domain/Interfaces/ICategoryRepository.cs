using ZOSS.Teste.Domain.Entities;

namespace ZOSS.Teste.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category?> GetByIdAsync(int id);
        Task<IEnumerable<Category>> GetAllAsync();
        Task AddAsync(Category category);
    }
}

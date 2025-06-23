using ZOSS.Teste.API.DTOs;

namespace ZOSS.Teste.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryResponseDTO?>> GetAllAsync();
        Task<CategoryResponseDTO?> GetByIdAsync(int id);
        Task<CategoryResponseDTO?> CreateAsync(CategoryRequestDTO categoryDto);
        Task<bool> DeleteAsync(int id);
    }
}
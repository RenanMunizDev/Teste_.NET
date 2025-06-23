using ZOSS.Teste.API.DTOs;
using ZOSS.Teste.Application.Interfaces;
using ZOSS.Teste.Domain.Entities;
using ZOSS.Teste.Domain.Interfaces;

namespace ZOSS.Teste.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<CategoryResponseDTO?>> GetAllAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return categories.Select(c => new CategoryResponseDTO
            {
                Id = c.Id,
                Name = c.Name
            });
        }

        public async Task<CategoryResponseDTO?> GetByIdAsync(int id)
        {
            var c = await _categoryRepository.GetByIdAsync(id);
            if (c == null) return null;

            return new CategoryResponseDTO { Id = c.Id, Name = c.Name };
        }

        public async Task<CategoryResponseDTO?> CreateAsync(CategoryRequestDTO categoryDto)
        {
            var category = new Category { Name = categoryDto.Name };
            await _categoryRepository.AddAsync(category);
            return new CategoryResponseDTO { Id = category.Id, Name = category.Name };
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var hasProducts = await _categoryRepository.HasProductsAsync(id);
            if (hasProducts)
                return false;

            return await _categoryRepository.DeleteAsync(id);
        }
    }
}

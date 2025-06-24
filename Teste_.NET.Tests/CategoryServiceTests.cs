using Xunit;
using Moq;
using ZOSS.Teste.Application.Services;
using ZOSS.Teste.Domain.Interfaces;
using ZOSS.Teste.Domain.Entities;
using ZOSS.Teste.API.DTOs;

namespace Teste_.NET.Tests
{
    public class CategoryServiceTests
    {
        [Fact]
        public async Task CreateAsync_ShouldReturnCreatedCategory()
        {
            var mockRepo = new Mock<ICategoryRepository>();
            mockRepo
                .Setup(r => r.AddAsync(It.IsAny<Category>()))
                .Returns(Task.CompletedTask)
                .Callback<Category>(c => c.Id = 1); 

            var service = new CategoryService(mockRepo.Object);

            var categoryDto = new CategoryRequestDTO { Name = "Eletrônicos" };

            var result = await service.CreateAsync(categoryDto);

            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("Eletrônicos", result.Name);
        }
    }
}

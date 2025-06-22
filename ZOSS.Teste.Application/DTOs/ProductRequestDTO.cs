namespace ZOSS.Teste.API.Models
{
    public class ProductRequestDTO
    {
        public int Id { get; set; } 
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal Value { get; set; }
        public int CategoryId { get; set; }
    }
}

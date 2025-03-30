namespace Domain.Entities
{
    public class Brand : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public ICollection<CategoryBrand> categoryBrands { get; set; }
    }
}

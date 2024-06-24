using API.DataAccessLayer.Models;

namespace API.BusinessLogicLayer.DTO.Category
{
    public class CategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        //public virtual ICollection<Product>? Products { get; set; }
    }
}

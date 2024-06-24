using API.DataAccessLayer.Models;

namespace API.BusinessLogicLayer.DTO.Category
{
    public class CategoryUpdateDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null;
        //public virtual ICollection<Product> Products { get; set; } = null;

    }
}

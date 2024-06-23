using API.DataAccessLayer.Models;

namespace API.BusinessLogicLayer.DTO.Category
{
    public class CategoryAddDTO
    {
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }
}

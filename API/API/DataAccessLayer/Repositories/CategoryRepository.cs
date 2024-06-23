using API.DataAccessLayer.Interfaces;
using API.DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace API.DataAccessLayer.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private ShopdbContext _context;

        public CategoryRepository(ShopdbContext context) : base(context)
        {
            _context = context;
        }

    }
}

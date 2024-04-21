using ECommerceAppTemplate.Data.Models;
using ECommerceAppTemplate.DataAccess.Data;
using ECommerceAppTemplate.DataAccess.Repository.Abstract;

namespace ECommerceAppTemplate.DataAccess.Repository.Concrete
{
    public class CategoryRepository : GeneralRepository<Category>, IOrderRepository
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            this._db = db;
        }


        public void Update(Category category)
        {
            _db.Categories.Update(category);
        }
    }
}

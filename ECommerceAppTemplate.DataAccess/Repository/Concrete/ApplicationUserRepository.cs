using ECommerceAppTemplate.Data.Models;
using ECommerceAppTemplate.DataAccess.Data;
using ECommerceAppTemplate.DataAccess.Repository.Abstract;

namespace ECommerceAppTemplate.DataAccess.Repository.Concrete
{
    public class ApplicationUserRepository : GeneralRepository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            this._db = db;
        }



    }
}

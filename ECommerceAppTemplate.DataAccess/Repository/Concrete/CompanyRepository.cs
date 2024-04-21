using ECommerceAppTemplate.Data.Models;
using ECommerceAppTemplate.DataAccess.Data;
using ECommerceAppTemplate.DataAccess.Repository.Abstract;

namespace ECommerceAppTemplate.DataAccess.Repository.Concrete
{
    public class CompanyRepository : GeneralRepository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            this._db = db;
        }

        public void Update(Company company)
        {
            _db.Companies.Update(company);
        }
    }
}

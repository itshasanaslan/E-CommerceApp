using ECommerceAppTemplate.Data.Models;

namespace ECommerceAppTemplate.DataAccess.Repository.Abstract
{
    public interface ICompanyRepository : IGeneralRepository<Company>
    {
        void Update(Company company);

    }
}

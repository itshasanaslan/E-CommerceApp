using ECommerceAppTemplate.Data.Models;

namespace ECommerceAppTemplate.DataAccess.Repository.Abstract
{
    public interface IOrderRepository : IGeneralRepository<Category>
    {
        void Update(Category category);

    }
}

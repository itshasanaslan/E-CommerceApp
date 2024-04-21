using ECommerceAppTemplate.Data.Models;

namespace ECommerceAppTemplate.DataAccess.Repository.Abstract
{
    public interface IProductRepository : IGeneralRepository<Product>
    {
        void Update(Product product);

    }
}

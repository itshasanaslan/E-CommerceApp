using ECommerceAppTemplate.Data.Models;

namespace ECommerceAppTemplate.DataAccess.Repository.Abstract
{
    public interface IShoppingCartRepository : IGeneralRepository<ShoppingCart>
    {
        void Update(ShoppingCart shoppingCart);

    }
}

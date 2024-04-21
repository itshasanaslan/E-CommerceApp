using ECommerceAppTemplate.Data.Models;

namespace ECommerceAppTemplate.DataAccess.Repository.Abstract
{
    public interface IOrderDetailRepository : IGeneralRepository<OrderDetail>
    {
        void Update(OrderDetail orderDetail);

    }
}

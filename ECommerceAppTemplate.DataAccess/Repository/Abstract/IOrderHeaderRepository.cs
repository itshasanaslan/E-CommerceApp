using ECommerceAppTemplate.Data.Models;

namespace ECommerceAppTemplate.DataAccess.Repository.Abstract
{
    public interface IOrderHeaderRepository : IGeneralRepository<OrderHeader>
    {
        void Update(OrderHeader orderHeader);
        void UpdateStatus(int id, string orderStatus, string? paymentStatus = null);
        void UpdateStripePaymentId(int id, string sessionId, string paymentIntendId);

    }
}

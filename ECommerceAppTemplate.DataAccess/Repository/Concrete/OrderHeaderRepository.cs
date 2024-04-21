using ECommerceAppTemplate.Data.Models;
using ECommerceAppTemplate.DataAccess.Data;
using ECommerceAppTemplate.DataAccess.Repository.Abstract;

namespace ECommerceAppTemplate.DataAccess.Repository.Concrete
{
    public class OrderHeaderRepository : GeneralRepository<OrderHeader>, IOrderHeaderRepository
    {
        private ApplicationDbContext _db;
        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            this._db = db;
        }


        public void Update(OrderHeader orderHeader)
        {
            _db.OrderHeaders.Update(orderHeader);
        }

        public void UpdateStatus(int id, string orderStatus, string? paymentStatus = null)
        {
            var orderFromDb = _db.OrderHeaders.FirstOrDefault(u => u.Id == id);
            if (orderFromDb != null)
            {
                orderFromDb.OrderStatus = orderStatus;
                if (!string.IsNullOrEmpty(paymentStatus))
                {
                    orderFromDb.PaymentStatus = paymentStatus;
                }
            }
        }

        public void UpdateStripePaymentId(int id, string sessionId, string paymentIntendId)
        {
            var orderFromDb = _db.OrderHeaders.FirstOrDefault(u => u.Id == id);
            if (!string.IsNullOrEmpty(sessionId))
            {
                orderFromDb.SessionId = sessionId;
            }
            if (!string.IsNullOrEmpty(paymentIntendId))
            {
                orderFromDb.PaymentIntentId = paymentIntendId;
                orderFromDb.PaymentDate = DateTime.Now;
            }
        }
    }
}

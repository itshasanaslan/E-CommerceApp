using ECommerceAppTemplate.Data.Models;
using ECommerceAppTemplate.DataAccess.Data;
using ECommerceAppTemplate.DataAccess.Repository.Abstract;

namespace ECommerceAppTemplate.DataAccess.Repository.Concrete
{
    public class OrderDetailRepository : GeneralRepository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            this._db = db;
        }


        public void Update(OrderDetail orderDetail)
        {
            _db.OrderDetails.Update(orderDetail);
        }
    }
}

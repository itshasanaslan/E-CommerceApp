using ECommerceAppTemplate.Data.Models;

namespace ECommerceAppTemplate.Data.ViewModels
{
    public class OrderVM
    {
        public OrderHeader OrderHeader { get; set; }
        public IEnumerable<OrderDetail> OrderDetail { get; set; }
    }
}

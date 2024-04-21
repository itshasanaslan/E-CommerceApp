using ECommerceAppTemplate.Data.Models;

namespace ECommerceAppTemplate.Data.ViewModels
{
    public class ShoppingCartVM
    {
        public IEnumerable<ShoppingCart> ShoppingCartList { get; set; }
        //  public double OrderTotal { get; set; }
        public OrderHeader OrderHeader { get; set; }

    }
}

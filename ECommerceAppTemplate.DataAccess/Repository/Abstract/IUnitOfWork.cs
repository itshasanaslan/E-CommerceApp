namespace ECommerceAppTemplate.DataAccess.Repository.Abstract
{
    public interface IUnitOfWork
    {
        IOrderRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
        ICompanyRepository CompanyRepository { get; }
        IShoppingCartRepository ShoppingCartRepository { get; }
        IApplicationUserRepository ApplicationUserRepository { get; }
        IOrderHeaderRepository OrderHeaderRepository { get; }
        IOrderDetailRepository OrderDetailRepository { get; }
        IProductImageRepository ProductImageRepository { get; }
        void Save();
    }
}

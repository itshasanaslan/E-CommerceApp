using ECommerceAppTemplate.Data.Models;

namespace ECommerceAppTemplate.DataAccess.Repository.Abstract
{
    public interface IProductImageRepository : IGeneralRepository<ProductImage>
    {
        void Update(ProductImage productImage);
        void UpdateRange(List<ProductImage> productImages);
    }
}

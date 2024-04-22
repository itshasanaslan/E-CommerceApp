using ECommerceAppTemplate.Data.Models;
using ECommerceAppTemplate.DataAccess.Data;
using ECommerceAppTemplate.DataAccess.Repository.Abstract;

namespace ECommerceAppTemplate.DataAccess.Repository.Concrete
{
    public class ProductImageRepository : GeneralRepository<ProductImage>, IProductImageRepository
    {
        private ApplicationDbContext _db;
        public ProductImageRepository(ApplicationDbContext db) : base(db)
        {
            this._db = db;
        }


        public void Update(ProductImage productImage)
        {
            _db.ProductImages.Update(productImage);
        }

        public void UpdateRange(List<ProductImage> productImages)
        {
            foreach (ProductImage productImage in productImages)
            {
                this.Update(productImage);
            }
        }
    }
}

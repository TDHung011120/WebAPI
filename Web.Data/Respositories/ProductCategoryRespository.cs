using System.Collections.Generic;
using System.Linq;
using Web.Data.Intrastructure;
using Web.Model.Models;

namespace Web.Data.Respositories
{
    public interface IProductCategoryRespository
    {
        //khai báo phương thức riêng cần tạo của table
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRespository : RespositoryBase<ProductCategory>, IProductCategoryRespository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public ProductCategoryRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table
        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.dbContext.ProductCategories.Where(c => c.Alias == alias);
        }
    }
}
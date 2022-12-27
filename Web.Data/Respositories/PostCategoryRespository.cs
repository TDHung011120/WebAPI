using Web.Data.Intrastructure;
using Web.Model.Models;

namespace Web.Data.Respositories
{
    public interface IPostCategoryRespository
    {
        //khai báo phương thức riêng cần tạo của table
    }

    public class PostCategoryRespository : RespositoryBase<Product>, IPostCategoryRespository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public PostCategoryRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table
    }
}
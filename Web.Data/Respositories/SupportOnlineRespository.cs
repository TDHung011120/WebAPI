using Web.Data.Intrastructure;
using Web.Model.Models;

namespace Web.Data.Respositories
{
    public interface ISupportOnlineRespository
    {
        //khai báo phương thức riêng cần tạo của table
    }

    public class SupportOnlineRespository : RespositoryBase<Product>, ISupportOnlineRespository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public SupportOnlineRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table
    }
}
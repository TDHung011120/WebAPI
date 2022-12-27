using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Data.Intrastructure;
using Web.Model.Models;

namespace Web.Data.Respositories
{
    
    public interface IOderDetailRespository
    {
        //khai báo phương thức riêng cần tạo của table

    }

    public class OderDetailRespository : RespositoryBase<Product>, IOderDetailRespository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public OderDetailRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table

    }
}

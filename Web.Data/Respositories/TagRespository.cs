using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Data.Intrastructure;
using Web.Model.Models;

namespace Web.Data.Respositories
{
    
    public interface ITagRespository
    {
        //khai báo phương thức riêng cần tạo của table

    }

    public class TagRespository : RespositoryBase<Product>, ITagRespository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public TagRespository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table

    }
}

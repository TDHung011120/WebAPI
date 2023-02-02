﻿using Web.Model.Models;
using Web.Data.Infrastructure;

namespace Web.Data.Repositories
{
    public interface IOderRepository : IRepository<Order>
    {
        //khai báo phương thức riêng cần tạo của table
    }

    public class OderRepository : RepositoryBase<Order>, IOderRepository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public OderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        // triển khai các phương thức mới thông qua interface riêng của table
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;

using Web.Data.Infrastructure;
using Web.Model.Models;

namespace Web.Data.Respositories
{
    
    public interface IProductRepository:IRepository<Product>
    {
        //khai báo phương thức riêng cần tạo của table
        
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

       

        // triển khai các phương thức mới thông qua interface riêng của table

    }
}

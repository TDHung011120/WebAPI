
using Web.Data.Infrastructure;
using Web.Model.Models;

namespace Web.Data.Repositories
{
    
    public interface IPageRepository:IRepository<Page>
    {
        //khai báo phương thức riêng cần tạo của table

    }

    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        //Dùng các phương thức đã được viết sẵn dùng chung
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

       
        // triển khai các phương thức mới thông qua interface riêng của table

    }
}

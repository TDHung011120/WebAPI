using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Web.Data.Intrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteMulti(Expression<Func<T, bool>> where);
        T GetSingleByID(int id);
        T GetSingleByCondition(Expression<Func<T, bool>> expression,string[] includes=null);
        IQueryable<T> GetAll(string[] includes = null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate,string[] includes=null);
        IQueryable GetAllMultiPaging(Expression<Func<T, bool>> filter,out int total,int index=0,int size=50,string[] includes=null);
         int Count(Expression<Func<T, bool>> where);
        bool CheckContaint(Expression<Func<T, bool>> predicate);
    }
}

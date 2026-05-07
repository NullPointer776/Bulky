using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SD7501Bulky.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T - Category
        IEnumerable<T> GetAll(Expression<Func<T,bool>>? filter=null, string? includeProperties = null);

        T Get(Expression<Func<T,bool>> filter, string? includeProperties = null, bool tracked=false);
        //Func<T, bool> is a function(lambda expression) that:
        //Takes an object of type T and Returns true or false
        //Using Expression means that it is an expression tree that will allow Entity Framework (or LINQ providers) to
        //Convert the condition into SQL and then Excute it in the database
        //filter represents the condition used to find the record
        //Translation is Select * from Categories where Name='Action'
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}

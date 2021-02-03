using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //T yalnızca herhangi bir class olabilir veya IEntity den implemente olan birşey olabilir
   public interface IEntityRepository<T> where T:class ,IEntity
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null); //null olanları filtreler
        T Get(Expression<Func<T, bool>> filter); //filtre vermemişse tüm datayı istiyor
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);  

       // List<T> GetAllByCategory(int categoryId);
    }
}

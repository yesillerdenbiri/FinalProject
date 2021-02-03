using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IProductDal // public yapmayı asla unutma
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);  //interface metodları kendiğinden publictir

        List<Product> GetAllByCategory(int categoryId);

    }
}

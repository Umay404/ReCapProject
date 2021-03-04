using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
   //generic constraint kısıtlama koyma
   //class:referans tip
   //IEntity:IEntity olabilir veya IEntity implement eden bir nesne olabilir.
   //new():newlenebilir olmalı.
  public  interface IEntityRepository<T> where T:class,IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


/// Coore katmanı diğer katmanları referans almaz. çok önemli


namespace Core.DataAccess
{
    //generic costraint 
    //class : reference tip
    // Ientity olabilir veya IEntitiy implemente eden bir nesne olabilir
    //new() : new2lenebilir olmalı. IEntity new lenemez
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}

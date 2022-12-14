using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{       
        //class:referans tip olmalı
        //ientity: ientity olabilir veya ientityi implement alan classlar
        //new(): newlenebilir olmalı yani ientity kullanılamaz interface olduğu için
        //core diğer katmanları referans almaz!!!!

    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}

using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
    // Class -- Referans type olabilir anlamına gelir.
    //new() -- newlenebilir olmak zorunda.
    // IEntity olmalı veya ondan implemente edilen bir class yazabilirsin.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll();

        T GetById(int id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}

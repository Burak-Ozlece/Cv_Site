using Microsoft.Ajax.Utilities;
using MvcCv.Models.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MvcCv.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        DbCvEntities db = new DbCvEntities();

        public List<T> List()
        {
            return db.Set<T>().ToList();
        }
        public void Tadd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }
        public void Tdel(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }
        public T TGet(int Id)
        {
            return db.Set<T>().Find(Id);
        }
        public void TUpdate(T p)
        {
            db.SaveChanges();
        }
        public T Find(Expression<Func<T,bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }
    }
}
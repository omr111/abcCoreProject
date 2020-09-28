﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace Core.dataAccess
{
    public class RepositoryBase<T, TContext> : IRepositoryBase<T> where T : class,new() where TContext : DbContext,new()
    {
        public void add(T entity)
        {
           using(var ctx=new TContext())
            {
                ctx.Entry(entity).State = EntityState.Added;
            }
        }

        public void delete(T entity)
        {
            using (var ctx = new TContext())
            {
                ctx.Entry(entity).State = EntityState.Deleted;
            }
        }

        public List<T> getAll(Expression<Func<T, bool>> filter = null)
        {
            using (var ctx = new TContext())
            {
                if (filter != null)
                    return ctx.Set<T>().Where(filter).ToList();
                else
                    return ctx.Set<T>().ToList();
             
            }
        }

        public T getOne(Expression<Func<T, bool>> filter)
        {
            using (var ctx = new TContext())
            {
                return ctx.Set<T>().FirstOrDefault(filter);
            }
           
        }

        public void update(T entity)
        {
            using (var ctx = new TContext())
            {
                ctx.Entry(entity).State = EntityState.Modified;
            }
        }
    }
}

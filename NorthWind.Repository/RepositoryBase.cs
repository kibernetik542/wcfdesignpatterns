using NorthWind.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NorthWind.Repository
{
    public class RepositoryBase<TT> : IRepository<TT> where TT : class
    {
        private static NorthWindContext context { get; set; }

        //Singleton pattern
        public static NorthWindContext Context
        {
            get
            {
                context = context ?? new NorthWindContext();
                return context;
            }
            set { context = value; }
        }



        public bool Add(TT entity)
        {
            Context.Set<TT>().Add(entity);
            try
            {
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(TT entity)
        {
            Context.Set<TT>().Remove(entity);
            try
            {
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<TT> Paging() => Context.Set<TT>().ToList();

        public bool Update(TT entity)
        {
            try
            {
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

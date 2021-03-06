﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

using entityframeworkrepository.cache.Extentions;
using entityframeworkrepository.core.entity;


namespace entityframeworkrepository.repository
{
    /// <summary>
    /// Generic Data Repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class GenericDataRepository<T> : IGenericDataRepository<T> where T : class
    {
        protected DbContext _entities;
        protected readonly IDbSet<T> _dbset;

        /// <summary>
        /// default ctor
        /// </summary>
        /// <param name="context"></param>
        public GenericDataRepository(DbContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));
            _entities = context;

            _entities.Configuration.AutoDetectChangesEnabled = false;
            _entities.Configuration.ProxyCreationEnabled = false;
            _entities.Configuration.ValidateOnSaveEnabled = true;

            _dbset = context.Set<T>();
        }


        /// <summary>
        /// GetAll
        /// </summary>
        /// <param name="navigationProperties"></param>
        /// <returns></returns>
        public virtual IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            try
            {
                    IQueryable<T> dbQuery = _entities.Set<T>();

                    dbQuery = navigationProperties.Aggregate(dbQuery, (current, navigationProperty) => current.Include(navigationProperty));

                    list = ToQueryable(dbQuery).ToList();
            }
            catch (SqlException ex)
            {
                throw new EntityException(string.Format("{0} - {1}", typeof (T), ex.Message), ex);
            }

            return list;
        }

        /// <summary>
        ///  Database Query Abstraction
        /// </summary>
        /// <param name="dbQuery"></param>
        /// <returns></returns>
        public IQueryable<T> ToQueryable(IQueryable<T> dbQuery)
        {
            return dbQuery.AsQueryable().AsNoTracking();
        }

        /// <summary>
        ///GetList
        /// </summary>
        /// <param name="where"></param>
        /// <param name="navigationProperties"></param>
        /// <returns></returns>
        public virtual IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            try
            {
                    IQueryable<T> dbQuery = _entities.Set<T>();

                    //EAGERLY
                    dbQuery = navigationProperties.Aggregate(dbQuery, (current, navigationProperty) => current.Include(navigationProperty));

                    list = ToQueryable(dbQuery).Where(where).ToList();
            }
            catch (SqlException ex)
            {
                throw new EntityException(string.Format("{0} - {1}", typeof (T), ex.Message), ex);
            }

            return list;
        }


        /// <summary>
        /// Paged list
        /// </summary>
        /// <param name="where"></param>
        /// <param name="page"></param>
        /// <param name="take"></param>
        /// <param name="navigationProperties"></param>
        /// <returns></returns>
       public virtual IList<T> GetPagedList(Func<T, bool> where, int page = 0, int take = 1000, params Expression<Func<T, object>>[] navigationProperties)
       {
           return GetList(where, navigationProperties).Skip(page * take).Take(take).ToList();
       }

       public virtual T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
       {
            T item = null;

            try
            {
                IQueryable<T> dbQuery = _entities.Set<T>();

                //Apply eager loading
                dbQuery = navigationProperties.Aggregate(dbQuery, (current, navigationProperty) => current.Include(navigationProperty));

                item = ToQueryable(dbQuery).FirstOrDefault(where);

            } catch (SqlException ex)
            {
                throw new EntityException(string.Format("{0} - {1}", typeof (T), ex.Message), ex);
            }

            return item;
        }

       public virtual T Add(params T[] items)
       {
            T last = null;
            try
            {
                var dbSet = _entities.Set<T>();
                foreach (var item in items)
                {
                    last = item;
                    dbSet.AddOrUpdate(item);
                    UpdatedCreatedTimestamp();
                }

                Save();
            }
            catch (SqlException ex)
            {
                throw new EntityException(string.Format("{0} - {1}", typeof(T), ex.Message), ex);
            }

            return last;
        }

        public virtual T Update(params T[] items)
        {
            T last = null;
            try
            {
                    var dbSet = _entities.Set<T>();
                    foreach (var item in items)
                    {
                        dbSet.AddOrUpdate(item);
                        UpdatedCreatedTimestamp();
                    }

                Save();
            }
            catch (SqlException ex)
            {
                throw new EntityException(string.Format("{0} - {1}", typeof(T), ex.Message), ex);
            }

            return last;
        }

        public T Remove(params T[] items)
        {
            T last = null;
            try
            {
                var dbSet = _entities.Set<T>();

                foreach (var item in items)
                {
                   dbSet.Local.Remove(item);
                   UpdatedCreatedTimestamp();
                }

                Save();
            }
            catch (SqlException ex)
            {
                throw new EntityException(string.Format("{0} - {1}", typeof(T), ex.Message), ex);
            }
            return last;
        }


        public IList<T> GetOrderedList(Func<T, bool> where,
          Expression<Func<T, object>>[] navExpressions,
          params Expression<Func<T, object>>[] props)
        {
            return GetList(where, navExpressions).AsEnumerable().OrderBy(props.ToArray()).ToList();
        }

        public IList<T> GetOrderedListDesc(Func<T, bool> where,
         Expression<Func<T, object>>[] navExpressions,
         params Expression<Func<T, object>>[] props)
        {
            return GetList(where, navExpressions).AsEnumerable().OrderByDescending(props.ToArray()).ToList();
        }




        public void Save()
        {
            _entities.SaveChanges();
        }

        protected static EntityState GetEntityState(EntityState entityState)
        {
            return entityState;
        }


        /// <summary>
        /// IAuditableEntity timestamps
        /// </summary>
        private void UpdatedCreatedTimestamp()
        {
            foreach (var entry in _entities.ChangeTracker.Entries<IAuditableEntity>())
            {
                var entity = entry.Entity;
                if (entity == null) continue;

                entry.State = GetEntityState(entry.State);
                if (entry.State == EntityState.Added)
                {
                    entity.CreatedDate = DateTime.Now;
                    entity.UpdatedDate = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entity.UpdatedDate = DateTime.Now;
                }
            }
        }


    }
}
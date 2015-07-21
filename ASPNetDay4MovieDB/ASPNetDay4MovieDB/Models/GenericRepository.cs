using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace ASPNetDay4MovieDB.Models
{
    public class GenericRepository : IGenericRepository
    {
        private DataContext _dataContext = new DataContext();

        /// <summary>
        /// Generic query method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IQueryable<T> Query<T>() where T : class 
        {
            return _dataContext.Set<T>().AsQueryable();
        }

        /// <summary>
        /// Non generic query method
        /// Use model type name instead of model type
        /// </summary>
        /// <param name="entityTypeName"></param>
        /// <returns></returns>
        public IQueryable Query(string entityTypeName)
        {
            var entityType = Type.GetType(entityTypeName);
            return _dataContext.Set(entityType).AsQueryable();
        }

        /// <summary>
        /// Find row by id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        public T Find<T>(params object[] keyValues) where T : class
        {
            return _dataContext.Set<T>().Find(keyValues);
        }

        /// <summary>
        /// Add new entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityToCreate"></param>
        public void Add<T>(T entityToCreate) where T : class
        {
            _dataContext.Set<T>().Add(entityToCreate);
        }

        /// <summary>
        /// Delete entities by ids
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="keyValues"></param>
        public void Delete<T>(params object[] keyValues) where T : class
        {
            var entity = this.Find<T>(keyValues);
            _dataContext.Set<T>().Remove(entity);
        }

        /// <summary>
        /// Save changes and throw validation exceptions
        /// </summary>
        public void SaveChanges()
        {
            try
            {
                _dataContext.SaveChanges();
            }
            catch (DbEntityValidationException dbVal)
            {
                var firstError = dbVal.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage;
                throw new ValidationException(firstError);
            }
        }

        /// <summary>
        /// Execute stored procedures and dynamic sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<T> SqlQuery<T>(string sql, params object[] parameters)
        {
            return this._dataContext.Database.SqlQuery<T>(sql, parameters);
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
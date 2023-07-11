using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    /// <summary>
    /// This is an interface for basic database operations.
    /// </summary>
    /// <typeparam name="T"> Generic reference type. T is an IEntity and its instance can be created.</typeparam>
    public interface IRepository<T> where T : class, IEntity, new() 
    {
        /// <summary>
        /// Get all the data by given filter.
        /// </summary>
        /// <param name="filter">Can be null or predicate</param>
        /// <returns>Collection of T</returns>
        List<T> GetAll(Expression<Func<T, bool>>? filter = null);
        
        /// <summary>
        /// Get the specific data by given filter.
        /// </summary>
        /// <param name="filter">Predicate that unique param of T</param>
        /// <returns>Instance of T</returns>
        T Get(Expression<Func<T, bool>> filter);

        /// <summary>
        /// Add the entity to database
        /// </summary>
        /// <param name="entity">T type entity</param>
        void Add(T entity);

        /// <summary>
        /// Update the entity in database
        /// </summary>
        /// <param name="entity">T type entity</param>
        void Update(T entity);

        /// <summary>
        /// Delete the entity in database
        /// </summary>
        /// <param name="entity">T type entity</param>
        void Delete(T entity);
    }
}

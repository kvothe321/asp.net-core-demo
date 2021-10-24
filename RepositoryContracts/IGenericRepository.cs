using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_demo.RepositoryContracts
{
    /// <summary>
    /// Contract interface for the GenericRepository class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Retrieves all T entities from the database.
        /// </summary>
        /// <returns></returns>
        Task<List<T>> ReadAllAsync();

        /// <summary>
        /// Retrieves a generic entity from the database.
        /// </summary>
        /// <param name="id">Entity's Identifier</param>
        /// <returns></returns>
        Task<T> ReadAsync(int id);

        /// <summary>
        /// Inserts a generic entity into the database.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        Task<T> CreateAsync(T t);

        /// <summary>
        /// Updates a generic entity
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        Task<T> UpdateAsync(T t);

        /// <summary>
        /// Deletes a generic entity from the database.
        /// </summary>
        /// <param name="id">Entity's identifier</param>
        /// <returns></returns>
        Task<T> DeleteAsync(int id);
    }
}
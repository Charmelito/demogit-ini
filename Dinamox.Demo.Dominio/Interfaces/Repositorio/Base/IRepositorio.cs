using System;
using System.Collections.Generic;
using System.Text;

namespace Dinamox.Demo.Dominio.Interfaces.Repositorio.Base
{
    public interface IRepositorio<T> where T : class
    {
        Task<T?> GetByIdAsync<TId>(TId id);
        Task<IEnumerable<T>> GetAllAsync();
        //Task<int> ObtenerCantitadTotalRegistros();
        Task AddAsync(T entidad);
        Task UpdateAsync(T entidad);
        Task DeleteAsync(T entidad);
    }
}

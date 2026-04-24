using Dinamox.Demo.Dominio.Interfaces.Repositorio.Base;
using Dinamox.Demo.Persistencia.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dinamox.Demo.Persistencia.Repositorios
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private readonly SACContext _context;
        protected readonly DbSet<T> _dbSet;

        public Repositorio(SACContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public virtual async Task<T?> GetByIdAsync<TId>(TId id)
        {
            return await _dbSet.FindAsync(id);
        }
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public virtual async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            // ✅ NO llamamos a SaveChangesAsync aquí
        }
        public virtual Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            // ✅ Solo marcamos como modificado
            return Task.CompletedTask;
        }
        public virtual Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            // ✅ Solo marcamos para eliminar
            return Task.CompletedTask;
        }
    }
}

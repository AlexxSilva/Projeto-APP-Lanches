using AppLanchesAPI.Domain;
using AppLanchesAPI.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLanchesAPI.Repositorio
{
    public class ComponenteRepository : IComponente
    {
        private readonly AppLanchesContext _context;

        public ComponenteRepository(AppLanchesContext context)
        {
            this._context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public async Task<Componente[]> GetAllComponenteAsync(int Produto_Id)
        {
            IQueryable<Componente> query = _context.Componentes
             .Include(c => c.Produto);

            return await query.ToArrayAsync();
        }
    }
}

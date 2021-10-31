using AppLanchesAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLanchesAPI.Repositorio
{
    public class LanchesRepository : ILanchesRepository
    {

        private readonly AppLanchesContext _context;

        public LanchesRepository(AppLanchesContext context)
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

        public async Task<Produto[]> GetAllProdutoAsync()
        {
            IQueryable<Produto> query = _context.Produtos;
            return await query.ToArrayAsync();
        }

        public Task<Componente[]> GetAllComponenteAsync(int Produto_Id)
        {
            throw new NotImplementedException();
        }
    }
}

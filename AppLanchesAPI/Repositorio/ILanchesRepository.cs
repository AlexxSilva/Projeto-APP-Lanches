using AppLanchesAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLanchesAPI.Repositorio
{
    public interface ILanchesRepository
    {
        //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //Produtos
        Task<Produto[]> GetAllProdutoAsync();

        //Componentes
        Task<Componente[]> GetAllComponenteAsync(int Produto_Id);
    }
}

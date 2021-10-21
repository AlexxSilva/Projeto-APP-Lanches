using AppLanchesAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLanchesAPI.Repositorio.Interfaces
{
    public interface IComponente : ILanchesRepository
    {
        Task<Componente[]> GetAllComponenteAsync(int Produto_Id);
    }
}

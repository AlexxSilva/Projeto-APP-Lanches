using AppLanchesAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLanchesAPI.Repositorio
{
    public class AppLanchesContext : DbContext
    {
        public AppLanchesContext(DbContextOptions<AppLanchesContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Componente> Componentes { get; set; }
        public DbSet<Componente> RendaFixa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PalestranteEvento>()
            //.HasKey(PE => new { PE.EventoId, PE.PalestranteId });

            base.OnModelCreating(modelBuilder);
        }
    }
}

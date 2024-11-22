using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data.Map;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data
{
    public class SistemaTarefasContex : DbContext
    {
        public SistemaTarefasContex(DbContextOptions<SistemaTarefasContex> options) 
            : base(options)
        { 
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefasModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}

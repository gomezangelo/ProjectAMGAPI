using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data.Map
{
    public class TarefaMap : IEntityTypeConfiguration<TarefasModel>
    {
        public void Configure(EntityTypeBuilder<TarefasModel> builder)
        {
            builder.HasKey(x => x.Tarefas_ID);
            builder.Property(x  => x.Nome).IsRequired().HasMaxLength(80);
            builder.Property(x => x.Descricao).HasMaxLength(255);
            builder.Property(x => x.Status).IsRequired();
        }
    }
}

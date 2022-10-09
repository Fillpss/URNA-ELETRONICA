using API_Urna.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Urna.Data.Map
{
    // Classe para mapeamento de entidade
    public class CandidatoMap : IEntityTypeConfiguration<Candidato>
    {
        public void Configure(EntityTypeBuilder<Candidato> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.NomeVice).IsRequired();
            builder.Property(x => x.DataDoRegistro).IsRequired();
        }
    }
}

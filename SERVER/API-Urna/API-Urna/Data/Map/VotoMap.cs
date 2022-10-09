using API_Urna.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace API_Urna.Data.Map
{
    public class VotoMap : IEntityTypeConfiguration<Voto>
    {
        public void Configure(EntityTypeBuilder<Voto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CandidatoId).IsRequired();
            builder.Property(x => x.DataDoVoto).IsRequired();
        }
    }
}

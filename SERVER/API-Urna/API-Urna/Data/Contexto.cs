using API_Urna.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Urna.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Candidato> Candidato { get; set; }
        public DbSet<Voto> Voto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Voto>()
                .HasOne<Candidato>(v => v.Candidato)
                .WithMany(c => c.Votos)
                .HasForeignKey(v => v.CandidatoId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
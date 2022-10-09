using API_Urna.Data;
using API_Urna.Models;
using API_Urna.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_Urna.Repository
{
    public class CandidatoRepositorio : ICandidatoRepositorio
    {
        private readonly Contexto _context;

        public CandidatoRepositorio(Contexto contexto)
        {
            _context = contexto;
        }

        public async Task<List<Candidato>> ListarCandidatos()
        {
            var candidatos = await _context.Candidato.Include(c => c.Votos).ToListAsync();
            return candidatos;
        }

        public async Task<Candidato> Adicionar(Candidato candidato)
        {
            await _context.Candidato.AddAsync(candidato);
            await _context.SaveChangesAsync();
            return candidato;
        }

        public async Task<bool> Apagar(int id)
        {
            Candidato candidatoPeloId = await _context.Candidato
                .FirstOrDefaultAsync(c => c.Id == id);

            if (candidatoPeloId == null)
            {
                throw new Exception($"O Id {id} é inválido");
            }

            _context.Candidato.Remove(candidatoPeloId);
            await _context.SaveChangesAsync();
            return true;

        }
    }
}
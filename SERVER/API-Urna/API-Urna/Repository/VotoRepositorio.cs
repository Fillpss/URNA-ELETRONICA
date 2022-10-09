using API_Urna.Data;
using API_Urna.Models;
using API_Urna.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API_Urna.Repository
{
    public class VotoRepositorio : IVotoRepositorio
    {
        private readonly Contexto _context;

        public VotoRepositorio(Contexto contexto)
        {
            _context = contexto;
        }

        public async Task<Voto> Adicionar(Voto voto)
        {
            await _context.Voto.AddAsync(voto);
            await _context.SaveChangesAsync();
            return voto;
        }

        public async Task<List<Voto>> ListarVotos()
        {
            var votos = await _context.Voto.ToListAsync();
            return votos;
        }
    }
}
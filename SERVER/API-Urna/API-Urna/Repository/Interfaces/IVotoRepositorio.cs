using API_Urna.Models;

namespace API_Urna.Repository.Interfaces
{
    public interface IVotoRepositorio
    {
        Task<List<Voto>> ListarVotos();
        Task<Voto> Adicionar(Voto voto);
    }
}
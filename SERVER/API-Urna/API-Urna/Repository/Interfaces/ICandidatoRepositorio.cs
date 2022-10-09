using API_Urna.Models;

namespace API_Urna.Repository.Interfaces
{
    public interface ICandidatoRepositorio
    {
        // Interface com os "Contratos" para o candidato
        Task<List<Candidato>> ListarCandidatos();
        Task<Candidato> Adicionar(Candidato candidato);
        Task<bool> Apagar(int id);
    }
}
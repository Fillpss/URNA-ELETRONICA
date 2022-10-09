using API_Urna.Models;
using API_Urna.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Urna.Controllers
{
    [Route("api/[controller]")] // rota: localhost:{porta}/api/candidato
    [ApiController]
    public class CandidatoController : ControllerBase
    {
        private readonly ICandidatoRepositorio _candidatoRepositorio;

        public CandidatoController(ICandidatoRepositorio candidatoRepositorio)
        {
            _candidatoRepositorio = candidatoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Candidato>>> BuscarCandidatos()
        {
            List<Candidato> candidatos = await _candidatoRepositorio.ListarCandidatos();
            return Ok(candidatos);
        }

        [HttpPost]
        public async Task<ActionResult<Candidato>> Criar([FromBody] Candidato candidatoModel)
        {
            Candidato candidato = await _candidatoRepositorio.Adicionar(candidatoModel);
            return Ok(candidato);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Candidato>> Deletar(int id)
        {
            bool apagado = await _candidatoRepositorio.Apagar(id);
            return Ok(apagado);
        }

    }
}
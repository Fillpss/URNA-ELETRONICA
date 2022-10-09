using API_Urna.Models;
using API_Urna.Repository;
using API_Urna.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Urna.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VotoController : ControllerBase
    {
        private readonly IVotoRepositorio _votoRepositorio;

        public VotoController(IVotoRepositorio votoRepositorio)
        {
            _votoRepositorio = votoRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Voto>>> ListaDeVotos()
        {
            List<Voto> voto = await _votoRepositorio.ListarVotos();
            return Ok(voto);
        }

        [HttpPost]
        public async Task<ActionResult<Voto>> Criar([FromBody] Voto votoModel)
        {
            Voto voto = await _votoRepositorio.Adicionar(votoModel);
            return Ok(voto);
        }
    }
}

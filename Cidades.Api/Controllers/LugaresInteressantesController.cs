using System.Linq;
using Cidades.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cidades.Api.Controllers
{


    //[Produces("application/xml")]
    [Route("api/cidades")]
    public class LugaresInteressantesController : Controller
    {
        [HttpGet("{cidadeId}/lugaresinteressantes")]
        public IActionResult ObterLugaresInteressantes(int cidadeId)
        {
            var cidade = CidadeDataStore.ObterCidades.Cidades.FirstOrDefault(c => c.Id == cidadeId);

            if (cidade == null)
                return NotFound();

            return Ok(cidade);
        }


        [HttpGet("{cidadeId}/lugaresinteressantes/{id}", Name = "ObterLugaresInteressantes")]
        public IActionResult ObterLugaresInteressantes(int cidadeId, int id)
        {
            var cidade = CidadeDataStore.ObterCidades.Cidades.FirstOrDefault(c => c.Id == cidadeId);

            if (cidade == null)
                return NotFound();

            var lugaresInteressatnes = cidade.LugaresInteressantes.FirstOrDefault(p => p.Id == id);

            if (lugaresInteressatnes == null)
                return NotFound();

            return Ok(lugaresInteressatnes);
        }





        [HttpPost("{cidadeId}/lugaresInteressantes")]
        public IActionResult CriarLugaresInteressanteas(int cidadeId,
            [FromBody] LugaresInteressantesCriacaoDto lugaresInteressantes)
        {
            if (lugaresInteressantes == null)
            {
                return BadRequest();
            }


            var cidade = CidadeDataStore.ObterCidades.Cidades.FirstOrDefault(c => c.Id == cidadeId);

            if (cidade == null)
            {
                return NotFound();
            }

            // demo purposes - to be improved
            var maxLugaresInteressantesId = CidadeDataStore.ObterCidades.Cidades.SelectMany(
                c => c.LugaresInteressantes).Max(p => p.Id);

            var finalLugaresInteressantes = new LugaresInteressantesDto()
            {
                Id = ++maxLugaresInteressantesId,
                Nome = lugaresInteressantes.Nome,
                Descricao = lugaresInteressantes.Descricao
            };

            cidade.LugaresInteressantes.Add(finalLugaresInteressantes);

            return CreatedAtRoute("ObterLugaresInteressantes", new
                {cidadeId = cidadeId, id = finalLugaresInteressantes.Id}, finalLugaresInteressantes);
        }
    }
}
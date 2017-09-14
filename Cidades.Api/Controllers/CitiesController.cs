using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cidades.Api.Controllers
{
    //[Produces("application/json")]
    [Route("api/Cities")]
    public class CitiesController : Controller
    {
        public JsonResult GetCities()
        {
            //return new JsonResult(new List<object>
            //{
            //    new {id = 1, Name = "São Paulo"},
            //    new {id = 2, Name = "Rio de Janeiro"}
            //});

            return new JsonResult(CidadeDataStore.ObterCidades.Cidades);
        }


        //public JsonResult GetCities2() => new JsonResult(new List<object>
        //{
        //    new {id = 1, Name = "São Paulo"},
        //    new {id = 2, Name = "Rio de Janeiro"}
        //});

        [HttpGet("{id}")]
        public JsonResult GetCidades(int id)
        {

            var cidade = CidadeDataStore.ObterCidades.Cidades.FirstOrDefault(c => c.Id == id);
            return new JsonResult(cidade);
        }
    }
}
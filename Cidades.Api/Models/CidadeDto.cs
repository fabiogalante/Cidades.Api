using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cidades.Api.Models
{
    public class CidadeDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public int NumeroLugaresInteressantes => LugaresInteressantes.Count;

        public ICollection<LugaresInteressantesDto> LugaresInteressantes { get; set; } =
            new List<LugaresInteressantesDto>();


    }
}

using System.Collections.Generic;
using Cidades.Api.Models;

namespace Cidades.Api
{
    public class CidadeDataStore
    {
        // Auto-Property Initializer
        public static CidadeDataStore ObterCidades { get; } = new CidadeDataStore();


        public CidadeDataStore(List<CidadeDto> cidades)
        {
            Cidades = cidades;
        }


        public List<CidadeDto> Cidades { get; set; }

        public CidadeDataStore()
        {
            // init dummy data
            Cidades = new List<CidadeDto>
            {
                new CidadeDto
                {
                    Id = 1,
                    Nome = "New York City",
                    Descricao = "The one with that big park.",
                    LugaresInteressantes = new List<LugaresInteressantesDto>
                    {
                        new LugaresInteressantesDto
                        {
                            Id = 1,
                            Nome = "Central Park",
                            Descricao = "The most visited urban park in the United States."
                        },
                        new LugaresInteressantesDto
                        {
                            Id = 2,
                            Nome = "Empire State Building",
                            Descricao = "A 102-story skyscraper located in Midtown Manhattan."
                        }
                    }
                },
                new CidadeDto
                {
                    Id = 2,
                    Nome = "Antwerp",
                    Descricao = "The one with the cathedral that was never really finished.",
                    LugaresInteressantes = new List<LugaresInteressantesDto>
                    {
                        new LugaresInteressantesDto
                        {
                            Id = 3,
                            Nome = "Cathedral of Our Lady",
                            Descricao = "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans."
                        },
                        new LugaresInteressantesDto
                        {
                            Id = 4,
                            Nome = "Antwerp Central Station",
                            Descricao = "The the finest example of railway architecture in Belgium."
                        }
                    }
                },
                new CidadeDto
                {
                    Id = 3,
                    Nome = "Paris",
                    Descricao = "The one with that big tower.",
                    LugaresInteressantes = new List<LugaresInteressantesDto>
                    {
                        new LugaresInteressantesDto
                        {
                            Id = 5,
                            Nome = "Eiffel Tower",
                            Descricao =
                                "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel."
                        },
                        new LugaresInteressantesDto
                        {
                            Id = 6,
                            Nome = "The Louvre",
                            Descricao = "The world's largest museum."
                        }
                    }
                }
            };
        }
    }
}

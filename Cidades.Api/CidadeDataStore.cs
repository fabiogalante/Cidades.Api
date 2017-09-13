using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cidades.Api.Models;

namespace Cidades.Api
{
    public class CidadeDataStore
    {

        // Auto-Property Initializer
        public static CidadeDataStore ObterCidades { get; } = new CidadeDataStore();


        public List<CidadeDto> Cidades { get; set; }

        public CidadeDataStore()
        {
            // init dummy data
            Cidades = new List<CidadeDto>()
            {
                new CidadeDto
                {
                     Id = 1,
                     Nome = "New York City",
                     Descricao = "The one with that big park.",
                     //PointsOfInterest = new List<PointOfInterestDto>()
                     //{
                     //    new PointOfInterestDto() {
                     //        Id = 1,
                     //        Name = "Central Park",
                     //        Description = "The most visited urban park in the United States." },
                     //     new PointOfInterestDto() {
                     //        Id = 2,
                     //        Name = "Empire State Building",
                     //        Description = "A 102-story skyscraper located in Midtown Manhattan." },
                     //}
                },
                new CidadeDto
                {
                    Id = 2,
                    Nome = "Antwerp",
                    Descricao = "The one with the cathedral that was never really finished.",
                    //PointsOfInterest = new List<PointOfInterestDto>()
                    // {
                    //     new PointOfInterestDto() {
                    //         Id = 3,
                    //         Name = "Cathedral of Our Lady",
                    //         Description = "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans." },
                    //      new PointOfInterestDto() {
                    //         Id = 4,
                    //         Name = "Antwerp Central Station",
                    //         Description = "The the finest example of railway architecture in Belgium." },
                    // }
                },
                new CidadeDto
                {
                    Id= 3,
                    Nome = "Paris",
                    Descricao = "The one with that big tower.",
                    //PointsOfInterest = new List<PointOfInterestDto>()
                    // {
                    //     new PointOfInterestDto() {
                    //         Id = 5,
                    //         Name = "Eiffel Tower",
                    //         Description = "A wrought iron lattice tower on the Champ de Mars, named after engineer Gustave Eiffel." },
                    //      new PointOfInterestDto() {
                    //         Id = 6,
                    //         Name = "The Louvre",
                    //         Description = "The world's largest museum." },
                    // }
                }
            };



        }
    }
}

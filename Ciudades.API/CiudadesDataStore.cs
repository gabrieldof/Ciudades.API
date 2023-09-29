using Ciudades.API.Models;

namespace Ciudades.API
{
    public class CiudadesDataStore
    {
        public List<CiudadDto> Ciudades { get; set; }

        public static CiudadesDataStore  Current{ get; } = new CiudadesDataStore();

        public CiudadesDataStore() {
            Ciudades = new List<CiudadDto>()
        { new CiudadDto()
        {
            Id = 1,
            Name = "Test",
            Description = "Test"
        },
        new CiudadDto()
        {
            Id = 2,
            Name = "Rosario",
            Description = "Ciudad de Rosario"
        }

        };

        }


    }
}

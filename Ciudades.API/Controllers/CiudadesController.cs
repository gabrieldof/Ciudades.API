using Microsoft.AspNetCore.Mvc;

namespace Ciudades.API.Controllers
{
    [ApiController]
    [Route("api/ciudades")]
    public class CiudadesController : ControllerBase
    {
        [HttpGet]
        //public JsonResult GetCiudades()
        //{
        //   return new JsonResult(
        //    new List<object>
        //    {
        //            new {id =1, name = "Rosario"},
        //            new {id =2, name ="Buenos Aires"}
        //    });
        //}

        public IActionResult GetCiudades()
        {
            return Ok(CiudadesDataStore.Current.Ciudades);
        }

    }
}

using BookCase_02.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BookCase_02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private static List<AutorModel> autores = new List<AutorModel>
        {
            new AutorModel(1,"nome","sobrenome")
        };
    

    [HttpGet]
        public ActionResult<List<AutorModel>> BuscarAutores()
        {
            return autores;
   
        }
    }
}

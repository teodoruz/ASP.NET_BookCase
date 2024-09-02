using BookCase_02.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BookCase_02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        public AutorModel model = new AutorModel(1, "a", "cx");

        [HttpGet]
        public ActionResult<List<AutorModel>> BuscarAutores()
        {
            return Ok(model);
   
        }
    }
}

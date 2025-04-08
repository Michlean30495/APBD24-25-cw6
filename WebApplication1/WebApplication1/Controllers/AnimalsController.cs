using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controlers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        // api/{nazwa kontrolera bez Controller}
        [HttpGet]
        public IActionResult Get()
        {
            var lista = DataBase.tests;
            return Ok(lista);
        }
        
        // api/{nazwa kontrolera bez Controller}/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var element = DataBase.tests.FirstOrDefault(x => x.Id == id);
            return Ok(element);
        }

        
        //Post api/{nazwa kontrolera bez Controller}
        [HttpPost]
        public IActionResult Add(Test test)
        {
            DataBase.tests.Add(test);
            return Created();
        }
    }
    //pobierz get
    //dodaj post
    //zmien get
    //usun delete

    // GET api/animals/1
    // GET api/animals?id=1
}

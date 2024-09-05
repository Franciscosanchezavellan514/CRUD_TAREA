using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using WebApplication1.Models;
using WebApplication1.Servicios;
namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteService IEstudianteService;

        public EstudianteController(IEstudianteService estudianteService)
        {
            IEstudianteService = estudianteService;
        }

        [HttpGet]
        public ActionResult<List<Estudiante>> GetAll()
        {
            return IEstudianteService.GetALL();
        }

        [HttpGet("{id}")]
        public ActionResult<Estudiante> GetByID(int id)
        {
            var test = IEstudianteService.GetByID(id);
            if (test == null) return NotFound();
            return Ok(test);
            
        }

        [HttpPost]
        public ActionResult Add (Estudiante producto)
        {
            IEstudianteService.Add(producto);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Update (int id, Estudiante test)
        {
            var find = IEstudianteService.GetByID(id);
            if (find == null) return NotFound();
            test.Id = id;
            IEstudianteService.Update(test);
            return Ok();

        }

        [HttpDelete("{id}")]
        public ActionResult Delete (int id)
        {
            var find = IEstudianteService.GetByID(id);
            if (find == null) return NotFound();
            IEstudianteService.Delete(id);
            return Ok();
        }

    }
}

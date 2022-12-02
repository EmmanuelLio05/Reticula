using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reticula.Modelo;

namespace Reticula.Controllers {
    public class MateriaController : Controller {

        private ReticulaContext reticulaContext;

        public MateriaController(ReticulaContext reticulaContext) {
            this.reticulaContext = reticulaContext;
        }

        // GET: MateriaController
        public ActionResult Index() {
            return View();
        }

        // GET: MateriaController/Details/5
        [HttpGet("GetAll")]
        public ActionResult GetAll() {
            try {
                return Ok(reticulaContext.Materias);
            } catch (Exception ex) {
                return BadRequest();
            }
        }

        // GET: MateriaController/Create
        // GET: MateriaController/Create
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] Materia materia) {
            try {
                reticulaContext.Materias.Add(materia);
                reticulaContext.SaveChanges();
                return Ok();
            } catch (Exception ex) {
                return BadRequest();
            }
        }

        // GET: MateriaController/Edit/5
        [HttpPost("Edit")]
        public ActionResult Edit([FromBody] Materia materia) {
            try {
                reticulaContext.Materias.Update(materia);
                return Ok();
                reticulaContext.SaveChanges();
            } catch (Exception ex) {
                return BadRequest();
            }
        }

        // GET: MateriaController/Delete/5
        [HttpDelete("Delete")]
        public ActionResult Delete([FromBody] Materia materia) {
            try {
                return Ok(reticulaContext.Materias.Remove(materia));
            } catch (Exception ex) {
                return BadRequest();
            }
        }
    }
}

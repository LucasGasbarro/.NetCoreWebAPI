using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SmartSchool.API.Model;
using System.Linq;
using SmartSchool.API.Data;
using Microsoft.EntityFrameworkCore;

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly SmartContext _context;

        public ProfessorController(SmartContext context)
        {
            _context = context;
        }

        //GET: api/Professor
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Professores);
        }

        //GET: api/Professor/byId/{id}
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var professor = _context.Professores.FirstOrDefault(p => p.Id == id);

            if (professor == null) return BadRequest("Professor não foi encontrado!");

            return Ok(professor);
        }

        //GET: api/Professor/byName
        [HttpGet("byName")]
        public IActionResult GetByName(string nome)
        {
            var professor = _context.Professores.FirstOrDefault(professor =>
                            professor.Nome.Contains(nome));
            if (professor == null) return BadRequest("Professor não encontrado!");

            return Ok(professor);
        }

        // POST: api/Professor/
        [HttpPost]
        public IActionResult Post(Professor professor)
        {
            _context.Add(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        // PUT api/Professor/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Professor professor)
        {
            var prof = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (prof == null) return BadRequest("Professor não encontrado!");

            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        // PATCH api/Professor/5
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Professor professor)
        {
            var prof = _context.Professores.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (prof == null) return BadRequest("Professor não encontrado!");

            _context.Update(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        // DELETE api/Professor/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var prof = _context.Professores.FirstOrDefault(a => a.Id == id);
            if (prof == null) return BadRequest("Professor não encontrado!");

            _context.Remove(prof);
            _context.SaveChanges();
            return Ok();
        }
    }
}

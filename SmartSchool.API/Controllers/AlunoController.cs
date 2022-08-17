using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SmartSchool.API.Model;
using System.Linq;
using SmartSchool.API.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly SmartContext _context;

        public AlunoController(SmartContext context)
        {
            _context = context;
        }

        // GET: api/Aluno
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Alunos);
        }

        // GET: api/Aluno/byId/{id}
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = _context.Alunos.FirstOrDefault(aluno => aluno.Id == id);

            if (aluno == null) return BadRequest("Aluno não foi encontrado!");

            return Ok(aluno);
        }

        // GET: api/Aluno/byName
        [HttpGet("byName")]
        public IActionResult GetByNome(string nome, string sobrenome)
        {
            var aluno = _context.Alunos.FirstOrDefault(aluno => 
                aluno.Nome.Contains(nome) && 
                aluno.Sobrenome.Contains(sobrenome));

            if (aluno == null) return BadRequest("Aluno não foi encontrado!");

            return Ok(aluno);
        }

        // POST: api/Aluno/aluno
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _context.Add(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {
            _context.Update(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }

        // PATCH api/<AlunoController>/5
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
            _context.Update(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            return Ok();
        }
    }
}

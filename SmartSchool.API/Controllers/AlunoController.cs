using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SmartSchool.API.Model;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSchool.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>()
        {
            new Aluno()
            {
                Id = 1,
                Nome = "Marcos",
                Sobrenome = "Schmidt",
                Telefone = "(12)34567-8901"
            },
            new Aluno()
            {
                Id = 2,
                Nome = "Marta",
                Sobrenome = "Kent",
                Telefone = "(11)11111-1111"
            },
            new Aluno()
            {
                Id = 3,
                Nome = "Lucas",
                Sobrenome = "Gasbarro",
                Telefone = "(22)22222-2222"
            },
        };

        // GET: api/Aluno
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Alunos);
        }

        // GET: api/Aluno/byId/{id}
        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(aluno => aluno.Id == id);

            if (aluno == null) return BadRequest("Aluno não foi encontrado!");

            return Ok(aluno);
        }

        // GET: api/Aluno/byName
        [HttpGet("byName")]
        public IActionResult GetByNome(string nome, string sobrenome)
        {
            var aluno = Alunos.FirstOrDefault(aluno => 
                aluno.Nome.Contains(nome) && 
                aluno.Sobrenome.Contains(sobrenome));

            if (aluno == null) return BadRequest("Aluno não foi encontrado!");

            return Ok(aluno);
        }

        // POST: api/Aluno/aluno
        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            

            return Ok(aluno);
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Aluno aluno)
        {

            return Ok(aluno);
        }

        // PATCH api/<AlunoController>/5
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {

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

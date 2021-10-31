using AppLanchesAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLanchesAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        public readonly ILanchesRepository _repo;

        public ProdutoController(ILanchesRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _repo.GetAllProdutoAsync();
                return Ok(results);
            }
            catch (Exception)
            {
                //return BadRequest();
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dados falhou");

            }

        }

    }
}

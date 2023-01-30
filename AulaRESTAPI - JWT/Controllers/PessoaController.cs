using AulaRESTAPI.Data;
using AulaRESTAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AulaRESTAPI.Controllers
{
    [Authorize]
    [Route("api")]
    [DisableCors]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IJWTAuthenticationManager jWTAuthenticationManager;

        public PessoaController(IJWTAuthenticationManager jWTAuthenticationManager)
        {
            this.jWTAuthenticationManager = jWTAuthenticationManager;
        }


        //.....  private readonly AppDbContext _context;
        //.....  public PessoaController(AppDbContext context)
        //.....  {
        //.....     _context = context;
        //.....  }

        [HttpGet]
        [Route("pessoas")]
        public async Task<IActionResult> GetAllAsync([FromServices] AppDbContext _context)
        {
            var pessoas = await _context.Pessoas
                .AsNoTracking()
                .ToListAsync();

            return pessoas == null ? NotFound() : Ok(pessoas);
        }

        [HttpGet]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute]int id, [FromServices] AppDbContext _context)  //[FromServices] AppDbContext _context
        {
            var pessoa = await _context.Pessoas
                .AsNoTracking()
                .FirstOrDefaultAsync(p=>p.Id == id);

            return pessoa == null ? NotFound() : Ok(pessoa);
        }

        [HttpPost]
        [Route("pessoas")]
        
        public async Task<IActionResult> CreateAsync([FromBody] Pessoa pessoa, [FromServices] AppDbContext _context)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                await _context.Pessoas.AddAsync(pessoa);
                await _context.SaveChangesAsync();
                return Created($"pessoas/{pessoa.Id}", pessoa);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpDelete]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute]int id, [FromServices] AppDbContext _context)
        {
            var pessoa = await _context.Pessoas
                .FirstOrDefaultAsync(x => x.Id == id);

            if (pessoa == null)
            {
                return BadRequest("Pessoa não encontrada!!!");
            }

            try
            {
                 _context.Pessoas.Remove(pessoa);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

            return Ok();
        }

        [HttpPut]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> PutAsync([FromRoute]int id, [FromBody] Pessoa pessoa, [FromServices] AppDbContext _context)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var p = await _context.Pessoas
                .FirstOrDefaultAsync(x=> x.Id == id); 
            
            if (p == null)
            {
                return NotFound();
            }

            try
            {
                p.Nome = pessoa.Nome;
                _context.Pessoas.Update(p);
                await _context.SaveChangesAsync();
                return Ok(p);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("autenticar")]
        public IActionResult Autheticate([FromBody] Usuario user)
        {
            var token = jWTAuthenticationManager.Authenticate(user.Username, user.Password);

            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);

        }

    }
}

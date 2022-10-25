using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Models;

namespace server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly DataContext context;
        public MoviesController(DataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<MoviesModel>>> Get()
        {
            return Ok(await context.Movies.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<MoviesModel>> Get(int id)
        {
            var movie = await context.Movies.FindAsync(id);
            if (movie == null)
                return BadRequest("Movie not found");
            return Ok(movie);
        }

        [HttpPost]
        public async Task<ActionResult<List<MoviesModel>>> AddMovie(MoviesModel movie)
        {
            context.Movies.Add(movie);
            await context.SaveChangesAsync();

            return Ok("Item added successfull");
        }
        
    }

}
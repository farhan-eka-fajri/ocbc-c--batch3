using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApi.Data;
using MovieApi.Models;

namespace MovieApi.Controllers{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase{

        private readonly ApiDbContext _context;

        public MovieController(ApiDbContext context){
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems(){
            var items = await _context.Items.ToListAsync();
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem([FromForm] ItemData data){
            if(ModelState.IsValid){
                await _context.Items.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new{data.id}, data);
            }
            return new JsonResult("Something went wrong"){StatusCode = 500};
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id){
            var item = await _context.Items.FirstOrDefaultAsync(x => x.id == id);

            if(item == null)
                return NotFound();
            return Ok(item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, ItemData item){

            if(id != item.id)
                return BadRequest();

            var existItem = await _context.Items.FirstOrDefaultAsync(x => x.id == id);

            if(existItem == null)
                return NotFound();

            existItem.name = item.name;
            existItem.genre = item.genre;
            existItem.duration = item.duration;
            existItem.releaseDate = item.releaseDate;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id){

            var existItem = await _context.Items.FirstOrDefaultAsync(x => x.id == id);

            if(existItem == null)
                return NotFound();
            _context.Items.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(existItem);
        }



    }

}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WhiskeyAndDucks.DataAccess;
using WhiskeyAndDucks.Models;

namespace WhiskeyAndDucks.Controllers
{
    [Route("api/whiskeys")]
    [ApiController]
    public class WhiskeysController : ControllerBase
    {
        WhiskeyRepository _repo = new WhiskeyRepository();
        [HttpGet]
        public List<Whiskey> GetAllWhiskeys()
        {
            return _repo.GetAll();
        }
        [HttpGet("name/{name}")]
        public IActionResult GetWhiskeyByName(string name)
        {
            var match = _repo.GetByName(name);
            if (match == null)
            {
                return NotFound();
            }

            return Ok(match);
        }
    }
}

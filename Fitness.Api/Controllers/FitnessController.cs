using Microsoft.AspNetCore.Mvc;

namespace Fitness.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FitnessController : Controller
    {
        public FitnessController()
        {

        }

        public IActionResult GetUsers()
        {
            return Ok();
        }

    }
}

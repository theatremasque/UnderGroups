using Microsoft.AspNetCore.Mvc;

namespace UnderGroups.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        [HttpGet]
        public ActionResult Vinne()
        {
            return Ok(42);
        }
    }
}

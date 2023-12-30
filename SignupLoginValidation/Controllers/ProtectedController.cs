using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignupLoginValidation.Models.DTO;

namespace SignupLoginValidation.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    [Authorize]
    public class ProtectedController : ControllerBase
    {
        public IActionResult GetData()
        {
            var status = new Status();
            status.StatusCode = 1;
            status.Message = "Data from protected controller";
            return Ok(status);
        }
    }
}

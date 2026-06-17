// Controller para testes, que aparecera apenas em depuração não em produção
#if DEBUG
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppProject.Core.Controllers.General
{
    [Route("api/general/[controller]/[action]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSample()
        {
            return this.Ok("This is a sample response from GeneralSampleController.");
        }
    }
}
#endif
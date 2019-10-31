using Microsoft.AspNetCore.Mvc;



namespace trabalho_interdisciplinar_388614.api.Controllers
{
    [Route("api/[controller]")]
    public class PresentationApiController : Controller
    {
        [HttpGet]
        [Route("calculateMinimumWaterRoutesBusiness")]
        public IActionResult CalculateMinimumWaterRoutesBusiness()
        {
            return Ok("Teste");
        }
    }
}

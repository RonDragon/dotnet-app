using Microsoft.AspNetCore.Mvc;
using MyProject.BLL;
namespace my_app.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
                private readonly MyBusinessLogic _bl;

        [HttpGet]
        [Route("employee")]
        public IActionResult GetAllEmployee()
        {
            return Ok(_bl.GetAllEntities());
        }
    }
}

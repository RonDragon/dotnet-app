using Microsoft.AspNetCore.Mvc;
using my_app.BLL;
namespace my_app.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
                private readonly MyBusinessLogic? _bl;

        [HttpGet]
        [Route("employee")]
        public IActionResult GetAllEmployee()
        {
            try{
            return Ok(_bl.GetAllEntities());
            }catch(Exception ex){
            return Ok(ex);

            }
        }
    }
}

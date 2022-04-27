using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace admin_portal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminUser _adminUserLogic;
        public AdminController(IAdminUser adminUserLogic)
        {
            _adminUserLogic = adminUserLogic;
        }
        [HttpPost("register")]
        public async Task<ActionResult<AdminUser>> Register(Admin request)
        {
            return Ok(_adminUserLogic.Register(request));
        }
    }
}

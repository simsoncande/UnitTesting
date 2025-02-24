using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitTestPOC.BusinessObjects;
using UnitTestPOC.Services.Interface;

namespace UnitTestPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("All")]
        public async Task<IActionResult> ListAsync()
        {
            List<User> users = new List<User>();
            users = await _userManager.ListAllUser();
            if (users.Any())
            {
                return Ok(users);
            }
            else
            {
                //If no Employee is Present return Not Found Status Code
                return NotFound();
            }
        }

        [HttpGet("Get")]
        public async Task<IActionResult> GetAsync(int id)
        {
            User user = new User();
            user = await _userManager.GetUser(id);
            if (user.Id > 0)
            {
                return Ok(user);
            }
            else
            {
                //If no Employee is Present return Not Found Status Code
                return NotFound();
            }
        }


    }

}

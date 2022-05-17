using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Stix_Mongo_API.Models;
using Stix_Mongo_API.Services;

namespace Stix_Mongo_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;


        public UserController(UserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public async Task<List<User>> Get() =>
            await _userService.GetAllUsersAsync();

        //TODO - change the template id length to match the one used in the db
        [HttpGet("{id:length(4)}")]
        public async Task<ActionResult<User>> Get(string id)
        {
            var user = await _userService.GetUserAsync(id);

            if (user is null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPost]
        public async Task<IActionResult> Post(User user)
        {
            var check = await _userService.GetUserAsync(user.Id);

            if(check.Equals(user))
            {
                return Conflict("User exists");
            }

            await _userService.CreateUserAsync(user);

            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }

        [HttpDelete("{id:length(4)}")]
        public async Task<IActionResult> Delete(String id)
        {
            var user = await _userService.GetUserAsync(id);

            if (user is null)
            {
                return NotFound();
            }

            await _userService.DeleteUserAsync(id);

            return NoContent();
        }

        [HttpPut("{id:length(4)}")]
        public async Task<IActionResult> Update(string id, User updatedUser)
        {
            var user = await _userService.GetUserAsync(id);

            if (user is null)
            {
                return NotFound();
            }

            updatedUser.Id = user.Id;

            await _userService.UpdateUserAsync(id, updatedUser);
            return Accepted();
        }


    }
}

using AuthenticationAPI.Extensions;
using Generic.Core.Models;
using Generic.Domain.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyRow = Generic.Core.Models.AuthResponse;

namespace AuthenticationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : Controller
    {
        private ILogger<AuthenticationController> logger;
        private IAuthRepository repository;
        public AuthenticationController(IAuthRepository repository, ILogger<AuthenticationController> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        // GET: Get User Profile, using UserID.
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<MyRow>))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponse))]
        public async Task<ActionResult> GetUserProfile(string UserId)
        {
            try
            {
                var result = await repository.FindByIdAsync(UserId);
                
                if (result != null)
                    return Ok(result);
                else
                    return NoContent();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                var error = new Error() { code = "99", message = "System malfunction" };
                return StatusCode(500, new ErrorResponse() { error = error });
            }
        }

        // Create User profile
        [HttpPost("Create-User-Profile")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(MyRow))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponse))]
        public async Task<ActionResult> CreateUser(User_Details user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());
            try
            {
                //var result = await repository.InsertAsync();
                var result = "";
                return null;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }

        // Update User profile
        [HttpPut("Update-User-Profile")]
        public async Task<ActionResult> UpdateUser(int userId)
        {
            return null;
        }

        // Delete User Profile
        [HttpDelete("Delete-User-Profile")]
        public async Task<ActionResult> DeleteUser(int UserId)
        {
            return null;
        }

    }
}

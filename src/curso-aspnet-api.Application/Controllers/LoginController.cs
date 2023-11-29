using System;
using System.Net;
using System.Threading.Tasks;
using curso_aspnet_api.Domain.Dtos;
using curso_aspnet_api.Domain.Entities;
using curso_aspnet_api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace curso_aspnet_api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _service;
        public LoginController(ILoginService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<object>> Login([FromBody] LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (loginDto == null)
            {
                return BadRequest();
            }

            try
            {
                var result = await _service.FindByLogin(loginDto);

                if (result != null)
                {
                    return Ok(result);
                }

                return NotFound();
            }
            catch (ArgumentException e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
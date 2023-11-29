using System;
using System.Threading.Tasks;
using curso_aspnet_api.Domain.Interfaces.Services.Uf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace curso_aspnet_api.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UfController : ControllerBase
    {
        private readonly IUfService _service;
        public UfController(IUfService service)
        {
            _service = service;
        }

        [Authorize("Bearer")]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.GetAll();
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpGet("{id:guid}")]
        public async Task<ActionResult> GetById(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Get(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
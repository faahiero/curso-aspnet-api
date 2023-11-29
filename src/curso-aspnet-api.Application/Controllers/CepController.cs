using System;
using System.Threading.Tasks;
using curso_aspnet_api.Domain.Dtos.Cep;
using curso_aspnet_api.Domain.Interfaces.Services.Cep;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace curso_aspnet_api.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CepController : ControllerBase
    {
        private readonly ICepService _cepService;

        public CepController(ICepService cepService)
        {
            _cepService = cepService;
        }

        [Authorize("Bearer")]
        [HttpGet("{id:guid}", Name = "GetCepWithId")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var result = await _cepService.Get(id);
                if (result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpGet("{cep}", Name = "GetCepWithCep")]
        public async Task<ActionResult> Get(string cep)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var result = await _cepService.Get(cep);
                if (result == null)
                    return NotFound();
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CepCreateDto cep)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var result = await _cepService.Post(cep);
                if (result == null)
                    return BadRequest();
                return Created(new Uri(Url.Link("GetCepWithId", new {id = result.Id})), result);
            }
            catch (ArgumentException e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] CepUpdateDto cep)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var result = await _cepService.Put(cep);
                if (result == null)
                    return BadRequest();
                return Ok(result);
            }
            catch (ArgumentException e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                return Ok(await _cepService.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
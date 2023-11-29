using System;
using System.Threading.Tasks;
using curso_aspnet_api.Domain.Dtos.Municipio;
using curso_aspnet_api.Domain.Interfaces.Services.Municipio;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace curso_aspnet_api.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MunicipioController : ControllerBase
    {
        private readonly IMunicipioService _municipioService;
        public MunicipioController(IMunicipioService municipioService)
        {
            _municipioService = municipioService;
        }

        [Authorize("Bearer")]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _municipioService.GetAll();
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
        [HttpGet("{id:guid}")]
        public async Task<ActionResult> GetById(Guid id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _municipioService.Get(id);
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
        [HttpGet("{municipioId:guid}", Name = "GetMunicipioWithId")]
        public async Task<ActionResult> GetCompleteById(Guid municipioId)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _municipioService.GetCompleteById(municipioId);
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
        [HttpGet("{codIBGE:int}", Name = "GetMunicipioWithIBGE")]
        public async Task<ActionResult> GetCompleteByIBGE(int codIBGE)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _municipioService.GetCompleteByIBGE(codIBGE);
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
        public async Task<ActionResult> Post([FromBody] MunicipioCreateDto municipio)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _municipioService.Post(municipio);
                if (result == null)
                    return BadRequest();

                return Created(new Uri(Url.Link("GetMunicipioWithId", new { id = result.Id })), result);
            }
            catch (ArgumentException e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] MunicipioUpdateDto municipio)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var result = await _municipioService.Put(municipio);
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
                return Ok(await _municipioService.Delete(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode(500, e.Message);
            }
        }

    }
}
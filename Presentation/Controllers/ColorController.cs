using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MonitoPetsBackend.Domain.Entities;
using MonitoPetsBackend.Domain.Services;
using MonitoPetsBackend.Infrastructure.Common.Exceptions;
using MonitoPetsBackend.Presentation.DTOs.Color;
using System.Net;

namespace MonitoPetsBackend.Presentation.Controllers
{
    [ApiController]
    [Route("api/colors")]
    [Produces("application/json")]
    public class ColorController : ControllerBase
    {
        private readonly IColorService _service;
        private readonly IMapper _mapper;

        public ColorController(IColorService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetColorResponseDTO>>> GetAllColors()
        {
            try
            {
                var colors = await _service.GetAllColors();
                var response = _mapper.Map<IEnumerable<GetColorResponseDTO>>(colors);
                return Ok(response);
            }
            catch (ValidationException exception) when (exception.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound(exception.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<GetColorResponseDTO>> GetColorById(int id)
        {
            try
            {
                var color = await _service.GetColorById(id);
                var response = _mapper.Map<GetColorResponseDTO>(color);
                return Ok(response);
            }
            catch (ValidationException exception) when (exception.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound(exception.Message);
            }
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<GetColorResponseDTO>> GetColorByName(string name)
        {
            try
            {
                var color = await _service.GetColorByName(name);
                var response = _mapper.Map<GetColorResponseDTO>(color);
                return Ok(response);
            }
            catch (ValidationException exception) when (exception.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound(exception.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> CreateColor(CreateColorRequestDTO request)
        {
            try
            {
                var color = _mapper.Map<Color>(request);
                await _service.CreateColor(color);
                return Ok();
            }
            catch (ValidationException exception) when (exception.StatusCode == HttpStatusCode.BadRequest)
            {
                return BadRequest(exception.Message);
            }
            catch (ValidationException exception) when (exception.StatusCode == HttpStatusCode.Conflict)
            {
                return Conflict(exception.Message);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateColor(int id, UpdateColorRequestDTO request)
        {
            try
            {
                var color = _mapper.Map<Color>(request);
                color.Id = id;
                await _service.UpdateColor(color);
                return Ok();
            }
            catch (ValidationException exception) when (exception.StatusCode == HttpStatusCode.BadRequest)
            {
                return BadRequest(exception.Message);
            }
            catch (ValidationException exception) when (exception.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound(exception.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteColor(int id)
        {
            try
            {
                await _service.DeleteColor(id);
                return Ok();
            }
            catch (ValidationException exception) when (exception.StatusCode == HttpStatusCode.BadRequest)
            {
                return BadRequest(exception.Message);
            }
            catch (ValidationException exception) when (exception.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound(exception.Message);
            }
        }
    }
}

﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MonitoPetsBackend.Domain.Entities;
using MonitoPetsBackend.Domain.Services;
using MonitoPetsBackend.Infrastructure.Common.Exceptions;
using MonitoPetsBackend.Presentation.DTOs.User;
using System.Net;

namespace MonitoPetsBackend.Presentation.Controllers
{
    [ApiController]
    [Route("api/users")]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetUserResponseDTO>>> GetAllUsers()
        {
            try
            {
                var users = await _userService.GetAllUsers();
                var response = _mapper.Map<IEnumerable<GetUserResponseDTO>>(users);
                return Ok(response);
            }
            catch (ValidationException exception) when (exception.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound(exception.Message);
            }
        }

        [HttpGet("name")]
        public async Task<ActionResult<IEnumerable<GetUserResponseDTO>>> GetUsersByName(string name)
        {
            try
            {
                var users = await _userService.GetUsersByName(name);
                var response = _mapper.Map<IEnumerable<GetUserResponseDTO>>(users);
                return Ok(response);
            }
            catch (ValidationException exception) when (exception.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound(exception.Message);
            }
        }

        [HttpGet("{isActive:bool}")]
        public async Task<ActionResult<IEnumerable<GetUserResponseDTO>>> GetUsersBtState(bool isActive)
        {
            try
            {
                var users = await _userService.GetUsersBtState(isActive);
                var response = _mapper.Map<IEnumerable<GetUserResponseDTO>>(users);
                return Ok(response);
            }
            catch (ValidationException exception) when (exception.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound(exception.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<GetUserResponseDTO>> GetUserById(int id)
        {
            try
            {
                var user = await _userService.GetUserById(id);
                var response = _mapper.Map<GetUserResponseDTO>(user);
                return Ok(response);
            }
            catch (ValidationException exception) when (exception.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound(exception.Message);
            }
        }

        [HttpGet("email")]
        public async Task<ActionResult<GetUserResponseDTO>> GetUserByEmail(string email)
        {
            try
            {
                var user = await _userService.GetUserByEmail(email);
                var response = _mapper.Map<GetUserResponseDTO>(user);
                return Ok(response);
            }
            catch (ValidationException exception) when (exception.StatusCode == HttpStatusCode.NotFound)
            {
                return NotFound(exception.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser(CreateUserRequestDTO request)
        {
            try
            {
                var user = _mapper.Map<User>(request);
                user.IsActive = true;
                await _userService.CreateUser(user);
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
        public async Task<ActionResult> UpdateUser(int id, UpdateUserRequestDTO request)
        {
            try
            {
                var user = _mapper.Map<User>(request);
                user.Id = id;
                await _userService.UpdateUser(user);
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
        public async Task<ActionResult> DeleteUser(int id)
        {
            try
            {
                await _userService.DeleteUser(id);
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

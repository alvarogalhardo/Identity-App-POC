using AutoMapper;
using Identity_App.Data.DTOs;
using Identity_App.Models;
using Identity_App.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity_App.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> Register(CreateUserDTO dto)
        {
           await _userService.RegisterAsync(dto);
           return Ok("Usuário cadastrado com sucesso!");
        }
    }


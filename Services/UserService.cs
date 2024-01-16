using AutoMapper;
using Identity_App.Data.DTOs;
using Identity_App.Models;
using Microsoft.AspNetCore.Identity;

namespace Identity_App.Services;

    public class UserService
{
    public UserService(IMapper mapper, UserManager<User> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;

    public async Task RegisterAsync(CreateUserDTO dto)
    {
        var user = _mapper.Map<User>(dto);
        var result = await _userManager.CreateAsync(user, dto.Password);
        if (!result.Succeeded)
        {
            throw new ApplicationException("Erro ao cadastrar usuário.");
        }
    }
}


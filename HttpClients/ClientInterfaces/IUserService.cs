﻿using System.Security.Claims;
using SharedDomain.DTOs;
using SharedDomain.Models;

namespace HttpClients.ClientInterfaces;

public interface IUserService
{
    public Task LoginAsync(string username, string password);
    public Task LogoutAsync();
    public Task RegisterAsync(User user);
    public Task<ClaimsPrincipal> GetAuthAsync();
    public Action<ClaimsPrincipal> OnAuthStateChanged { get; set; }
}
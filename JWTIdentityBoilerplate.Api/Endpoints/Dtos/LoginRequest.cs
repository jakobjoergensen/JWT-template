﻿namespace JWTIdentityBoilerplate.Api.Endpoints.Dtos;

internal record LoginRequest(string? Username, string? Email, string Password);
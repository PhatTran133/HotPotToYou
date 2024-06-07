﻿using HotPotToYou.Application.Common.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HotPotToYou.Services
{
    public class JwtService : IJwtService
    {
        public string CreateToken(int ID, string roles)
        {
            var claims = new List<Claim>
            {

                new(JwtRegisteredClaimNames.Sub, ID.ToString()),
                new(ClaimTypes.Role, roles)
            };



            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("H0t P0t T0 Y0u!!!"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                // issuer: "test",
                // audience: "api",
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

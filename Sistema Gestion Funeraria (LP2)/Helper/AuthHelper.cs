﻿using Microsoft.IdentityModel.Tokens;
using Sistema_Gestion_Funeraria__LP2_.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Sistema_Gestion_Funeraria__LP2_.Helper
{
    public class AuthHelper
    {
        private readonly IConfiguration config;
        private readonly SymmetricSecurityKey key;
        public AuthHelper(IConfiguration config)
        {
            this.config = config;
            this.key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.config["ApplicationSettings:JWT_Secret"]));
        }

        public string GenerateJWTToken(ApplicationUser user)
        {
            var claims = new List<Claim> {
               new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
               new Claim(ClaimTypes.GivenName, user.UserName),
               new Claim(JwtRegisteredClaimNames.Email, user.Email),
           };
            var jwtToken = new JwtSecurityToken(
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddDays(14),
                signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature)
                );
            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }
    }
}

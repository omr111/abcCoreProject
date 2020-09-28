using Core.Extensions;
using Entities.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public class jwtHelper : ITokenHelper
    {
        IConfiguration _configuration;
        tokenOptions _tokenOption;
        public jwtHelper(IConfiguration configuration)
        {
            _configuration = configuration;
            _tokenOption = _configuration.GetSection("TokenOptions").Get<tokenOptions>();
        }

        public AccessToken CreateToken(user user, List<role> userRoles)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenOption.securityKey));
            var singingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.Aes128CbcHmacSha256);
            var jwt = CreateJwtSecurityToken(_tokenOption, user, singingCredentials, userRoles);
            var JwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = JwtSecurityTokenHandler.WriteToken(jwt);
            return new AccessToken
            {
                token = token,
                expireDate = DateTime.Now.AddMinutes(_tokenOption.accessTokenExpiration)
            };

        }
        public JwtSecurityToken CreateJwtSecurityToken(tokenOptions tokenOptions, user user,
            SigningCredentials SigningCredentials, List<role> userRoles)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: DateTime.Now.AddMinutes(tokenOptions.accessTokenExpiration),
                notBefore: DateTime.Now,
                claims: setClaimsForUser(user, userRoles),
                signingCredentials: SigningCredentials
                );
            return jwt;
        }

        public IEnumerable<Claim> setClaimsForUser(user user, List<role> userRoles)
        {
            var claims = new List<Claim>();
            claims.addIdentifierId(user.Id);
            claims.addEmail(user.userEmail);
            claims.addNameSurname(user.name, user.surname);
            claims.addRole(userRoles.Select(x => x.roleName).ToArray());
            return claims;
        }
    }
}

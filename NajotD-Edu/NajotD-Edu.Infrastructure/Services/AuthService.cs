using Microsoft.EntityFrameworkCore;
using NajotD_Edu.Infrastructure.Abstractions;
using NajotD_Edu.Infrastructure.Persistense;
using NajotD_Edu.Infrastructure.Utils;

namespace NajotD_Edu.Infrastructure.Services
{
    public class AuthService : IAuthService
    {

        private readonly ApplicationDbContext _dbContext;
        private readonly ITokenService _tokenService;
        private object request;

        public AuthService(ApplicationDbContext dbContext, ITokenService tokenService)
        {
            _dbContext = dbContext;
            _tokenService = tokenService;
        }

        public async Task<string> LoginAsync(string username, string password)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserName == username);

            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (user.PasswordHash != HashGenerator.Generate(password))
            {
                throw new Exception("Password is wrong");
            }

            return _tokenService.GenerateAccessToken(user);
        }
    }
}

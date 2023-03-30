using Najotd_Edu.Domain.Entitys;
namespace NajotD_Edu.Infrastructure.Abstractions
{
    public interface ITokenService
    {
        string GenerateAccessToken(User user);
    }
}

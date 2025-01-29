using PatientsApp.Server.Entities;

namespace PatientsApp.Server.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}

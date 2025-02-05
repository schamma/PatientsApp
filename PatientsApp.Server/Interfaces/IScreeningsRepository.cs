using PatientsApp.Server.DTOs;
using PatientsApp.Server.Entities;

namespace PatientsApp.Server.Interfaces
{
    public interface IScreeningsRepository
    {
        Task<Screenings> GetUserScreenings(int userid);
        Task<AppUser> GetAppUserScreenings(int userId);
        Task<IEnumerable<ScreeningsDto>> GetScreenings();
    }
}

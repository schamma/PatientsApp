using PatientsApp.Server.DTOs;
using PatientsApp.Server.Entities;

namespace PatientsApp.Server.Interfaces
{
    public interface IFollowUpsRepository
    {
        Task<FollowUps> GetUserFollowUps(int userid);
        Task<AppUser> GetAppUserFollowUps(int userId);
        Task<IEnumerable<FollowUpsDto>> GetFollowUps(int userid);
    }
}

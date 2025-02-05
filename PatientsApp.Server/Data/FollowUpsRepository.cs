using PatientsApp.Server.DTOs;
using PatientsApp.Server.Entities;
using PatientsApp.Server.Interfaces;

namespace PatientsApp.Server.Data
{
    public class FollowUpsRepository : IFollowUpsRepository
    {
        private readonly DataContext _context;

        public FollowUpsRepository(DataContext context)
        {
            _context = context;
        }

        public Task<AppUser> GetAppUserFollowUps(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FollowUpsDto>> GetFollowUps()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FollowUpsDto>> GetFollowUps(int userid)
        {
            throw new NotImplementedException();
        }

        public Task<FollowUps> GetUserFollowUps(int userid)
        {
            throw new NotImplementedException();
        }
    }
}

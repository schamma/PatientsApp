using PatientsApp.Server.DTOs;
using PatientsApp.Server.Entities;
using PatientsApp.Server.Interfaces;

namespace PatientsApp.Server.Data
{
    public class ScreeningsRepository : IScreeningsRepository
    {
        private readonly DataContext _context;

        public ScreeningsRepository(DataContext context)
        {
            _context = context;
        }

        public Task<AppUser> GetAppUserScreenings(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ScreeningsDto>> GetScreenings()
        {
            throw new NotImplementedException();
        }

        public Task<Screenings> GetUserScreenings(int userid)
        {
            throw new NotImplementedException();
        }
    }
}

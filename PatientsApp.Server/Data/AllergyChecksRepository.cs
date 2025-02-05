using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using PatientsApp.Server.DTOs;
using PatientsApp.Server.Entities;
using PatientsApp.Server.Helpers;
using PatientsApp.Server.Interfaces;

namespace PatientsApp.Server.Data
{
    public class AllergyChecksRepository : IAllergyChecksRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public AllergyChecksRepository(DataContext context, IMapper mapper)
        {
            _context = context;
        }

        public void AddAllergy(AllergyChecks allergyChecks)
        {
            _context.AllergyChecks.Add(allergyChecks);
        }

        public void DeleteAllergy(AllergyChecks allergyChecks)
        {
            _context.AllergyChecks.Remove(allergyChecks);
        }

        public async Task<AllergyChecks> GetAllergies(int id)
        {
            return await _context.AllergyChecks.FindAsync(id);
        }

        public Task<IEnumerable<AllergyChecksDto>> GetAllergies(string currentUserId)
        {
            throw new NotImplementedException();
        }

        public Task<PagedList<AllergyChecksDto>> GetAllergiesForUser()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0; 
        }
    }
}

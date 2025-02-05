using PatientsApp.Server.DTOs;
using PatientsApp.Server.Entities;
using PatientsApp.Server.Helpers;

namespace PatientsApp.Server.Interfaces
{
    public interface IAllergyChecksRepository
    {
        void AddAllergy(AllergyChecks allergyChecks);
        void DeleteAllergy(AllergyChecks allergyChecks);
        Task<AllergyChecks> GetAllergies(int id);
        Task<PagedList<AllergyChecksDto>> GetAllergiesForUser();
        Task<IEnumerable<AllergyChecksDto>> GetAllergies(string currentUserId);
        Task<bool> SaveAllAsync();
    }
}

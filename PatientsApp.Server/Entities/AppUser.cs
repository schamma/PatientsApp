using PatientsApp.Server.Extensions;

namespace PatientsApp.Server.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string Gender { get; set; }
        public ICollection<AllergyChecks> AllergyChecks { get; set; }
        public ICollection<Screenings> Screenings { get; set; }
        public ICollection<FollowUps> FollowUps { get; set; }

        //public int GetAge()
        //{
        //    return DateOfBirth.CalculateAge();
        //}
    }
}

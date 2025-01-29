using PatientsApp.Server.Entities;

namespace PatientsApp.Server.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PhotoUrl { get; set; }
        //public string[] Reccomendations { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; } 
        public DateTime LastActive { get; set; }
        public string Gender { get; set; }
        public ICollection<PhotoDto> Photos { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace PatientsApp.Server.Entities
{
    [Table("Screenings")]
    public class Screenings
    {
        public int Id { get; set; }
        public string ScreeningType { get; set; }
        public bool IsComplete { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}

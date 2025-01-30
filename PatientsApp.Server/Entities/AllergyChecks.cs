using System.ComponentModel.DataAnnotations.Schema;

namespace PatientsApp.Server.Entities
{
    [Table("AllergyChecks")]
    public class AllergyChecks
    {
        public int Id { get; set; }
        public string AllergyType { get; set; }
        public bool IsComplete { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}

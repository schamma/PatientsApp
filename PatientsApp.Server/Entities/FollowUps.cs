using System.ComponentModel.DataAnnotations.Schema;

namespace PatientsApp.Server.Entities
{

    [Table("FollowUps")]
    public class FollowUps
    {
        public int Id { get; set; }
        public string FollowUpType { get; set; }
        public bool IsComplete { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
    }
}

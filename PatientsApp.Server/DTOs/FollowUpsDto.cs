namespace PatientsApp.Server.DTOs
{
    public class FollowUpsDto
    {
        public int Id { get; set; }
        public string FollowUpType { get; set; }
        public bool IsComplete { get; set; }
    }
}

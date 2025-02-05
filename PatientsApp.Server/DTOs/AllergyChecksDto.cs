namespace PatientsApp.Server.DTOs
{
    public class AllergyChecksDto
    {
        public int Id { get; set; }
        public string AllergyType { get; set; }
        public bool IsComplete { get; set; }
    }
}

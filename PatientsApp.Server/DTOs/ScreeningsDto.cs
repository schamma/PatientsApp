namespace PatientsApp.Server.DTOs
{
    public class ScreeningsDto
    {
        public int Id { get; set; }
        public string ScreeningType { get; set; }
        public bool IsComplete { get; set; }
    }
}

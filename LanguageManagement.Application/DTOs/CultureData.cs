namespace LanguageManagement.Application.DTOs
{
    public class CultureData
    {
        public string? Id { get; set; } // Made Id nullable
        public string? Name { get; set; }
        public string? CultureCode { get; set; }
        public string? ShortCode { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime InsertTime { get; set; }
    }
}
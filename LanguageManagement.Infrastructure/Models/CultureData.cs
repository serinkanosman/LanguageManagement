namespace LanguageManagement.Infrastructure.Models;

public class CultureData
{
    public string Id { get; set; }
    public string? Name { get; set; }
    public string? CultureCode { get; set; }

    public string? ShortCode { get; set; }
    public bool IsActive { get; set; }
    public DateTime InsertTime { get; set; }

    
}

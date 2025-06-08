
namespace LanguageManagement.Application.DTOs
{
public class RootResponse
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public List<CultureData> Data { get; set; } = new List<CultureData>(); // Fixed spelling and initialized to avoid CS8618
    public List<string> Errors { get; set; } = new List<string>(); // Initialized to avoid CS8618
    public int StatusCode { get; set; }
}
} // Add closing brace for namespace

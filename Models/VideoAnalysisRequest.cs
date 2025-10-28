namespace GenAI_Video_Analyzer.Models;

public class VideoAnalysisRequest
{
    public string VideoUrl { get; set; } = string.Empty;
    public string VideoName { get; set; } = string.Empty;
    public IFormFile? VideoFile { get; set; }
}
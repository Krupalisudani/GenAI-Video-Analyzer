namespace GenAI_Video_Analyzer.Models;

public class VideoAnalysisResponse
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public AnalysisResult? Result { get; set; }
    public string Error { get; set; } = string.Empty;
}
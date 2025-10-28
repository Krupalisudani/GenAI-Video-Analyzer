namespace GenAI_Video_Analyzer.Models;

public class AnalysisResult
{
    public string Summary { get; set; } = string.Empty;
    public List<string> DetectedObjects { get; set; } = new List<string>();
    public List<string> DetectedActions { get; set; } = new List<string>();
    public string SceneDescription { get; set; } = string.Empty;
    public string AnalysisTimestamp { get; set; } = string.Empty;
}
using GenAI_Video_Analyzer.Models;

namespace GenAI_Video_Analyzer.Services;

public interface IVideoAnalysisService
{
    Task<VideoAnalysisResponse> AnalyzeVideoAsync(VideoAnalysisRequest request);
    Task<VideoAnalysisResponse> AnalyzeVideoUrlAsync(string videoUrl);
}
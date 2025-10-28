using Microsoft.AspNetCore.Mvc;
using GenAI_Video_Analyzer.Models;
using GenAI_Video_Analyzer.Services;

namespace GenAI_Video_Analyzer.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IVideoAnalysisService _videoAnalysisService;

    public HomeController(ILogger<HomeController> logger, IVideoAnalysisService videoAnalysisService)
    {
        _logger = logger;
        _videoAnalysisService = videoAnalysisService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AnalyzeVideo(IFormFile videoFile, string videoUrl)
    {
        try
        {
            VideoAnalysisResponse response;

            if (!string.IsNullOrEmpty(videoUrl))
            {
                response = await _videoAnalysisService.AnalyzeVideoUrlAsync(videoUrl);
            }
            else if (videoFile != null && videoFile.Length > 0)
            {
                var request = new VideoAnalysisRequest
                {
                    VideoFile = videoFile,
                    VideoName = videoFile.FileName
                };
                response = await _videoAnalysisService.AnalyzeVideoAsync(request);
            }
            else
            {
                return Json(new { success = false, error = "Please provide either a video file or URL" });
            }

            return Json(response);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in AnalyzeVideo");
            return Json(new VideoAnalysisResponse 
            { 
                Success = false, 
                Error = $"Analysis failed: {ex.Message}" 
            });
        }
    }
}
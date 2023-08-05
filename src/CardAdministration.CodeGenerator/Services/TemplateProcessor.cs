using Microsoft.Extensions.Logging;
using RazorEngineCore;
using System;
using System.Threading.Tasks;

namespace CardAdministration.CodeGenerator.Services;

public class RazorTemplateProcessor: RazorEngine, ITemplateProcessor
{
    private readonly ILogger<RazorTemplateProcessor> _logger;

    public RazorTemplateProcessor(ILogger<RazorTemplateProcessor> logger){
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task DoWorkAsync()
    {
        _logger.LogInformation("DoWorkAsync");
    }

}


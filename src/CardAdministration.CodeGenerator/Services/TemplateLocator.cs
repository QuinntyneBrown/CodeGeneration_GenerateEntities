using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CardAdministration.CodeGenerator.Services;

public class TemplateLocator: ITemplateLocator
{
    private readonly ILogger<TemplateLocator> _logger;

    public TemplateLocator(ILogger<TemplateLocator> logger){
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task DoWorkAsync()
    {
        _logger.LogInformation("DoWorkAsync");
    }

}


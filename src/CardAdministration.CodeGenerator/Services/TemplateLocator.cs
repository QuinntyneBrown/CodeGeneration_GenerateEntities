using Microsoft.Extensions.Logging;
using System.IO.Abstractions;

namespace CardAdministration.CodeGenerator.Services;

public class TemplateLocator: ITemplateLocator
{
    private readonly ILogger<TemplateLocator> _logger;
    private readonly IFileSystem _fileSystem;

    public TemplateLocator(ILogger<TemplateLocator> logger, IFileSystem fileSystem){
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _fileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
    }

    public async Task<string> Get(string name)
    {
        _logger.LogInformation("DoWorkAsync");
    }

}


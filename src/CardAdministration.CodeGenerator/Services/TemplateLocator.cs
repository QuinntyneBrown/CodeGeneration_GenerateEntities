using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.IO.Abstractions;

namespace CardAdministration.CodeGenerator.Services;

public class TemplateLocator: ITemplateLocator
{
    private readonly ILogger<TemplateLocator> _logger;
    private readonly IFileSystem _fileSystem;
    private readonly TemplateLocatorOptions _options;
    public TemplateLocator(ILogger<TemplateLocator> logger, IFileSystem fileSystem, IOptions<TemplateLocatorOptions> optionsAccessor)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _fileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
        _options = optionsAccessor.Value;
    }

    public async Task<string> Get(string name)
    {
        _logger.LogInformation("Get template");

        return _fileSystem.File.ReadAllText(Path.Combine(_options.Directory, $"{name}.txt"));
    }

}

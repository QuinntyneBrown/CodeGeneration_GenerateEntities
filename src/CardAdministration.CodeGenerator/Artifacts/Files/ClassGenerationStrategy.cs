using CardAdministration.CodeGenerator.Services;
using Microsoft.Extensions.Logging;
using System.IO.Abstractions;

namespace CardAdministration.CodeGenerator.Artifacts.Files;

public class ClassGenerationStrategy : IArtifactGenerationStrategy<ClassModel>
{
    private readonly ILogger<ClassGenerationStrategy> _logger;
    private readonly IFileSystem _fileSystem;
    private readonly ITemplateLocator _templateLocator;
    private readonly ITemplateProcessor _templateProcessor;
    public ClassGenerationStrategy(ILogger<ClassGenerationStrategy> logger, IFileSystem fileSystem, ITemplateProcessor templateProcessor, ITemplateLocator templateLocator)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _fileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
        _templateProcessor = templateProcessor ?? throw new ArgumentNullException(nameof(templateProcessor));
        _templateLocator = templateLocator ?? throw new ArgumentNullException(nameof(templateLocator));

    }

    public async Task GenerateAsync(ClassModel model)
    {
        var template = await _templateLocator.Get("Class");

        var result = await _templateProcessor.ProcessAsync(template, model);
    }
}

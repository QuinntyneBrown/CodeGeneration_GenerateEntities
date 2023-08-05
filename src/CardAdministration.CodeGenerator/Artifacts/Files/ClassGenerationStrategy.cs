using Microsoft.Extensions.Logging;
using System.IO.Abstractions;

namespace CardAdministration.CodeGenerator.Artifacts.Files;

public class ClassGenerationStrategy : IArtifactGenerationStrategy<ClassModel>
{
    private readonly ILogger<ClassGenerationStrategy> _logger;
    private readonly IFileSystem _fileSystem;

    public ClassGenerationStrategy(ILogger<ClassGenerationStrategy> logger, IFileSystem fileSystem)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _fileSystem = fileSystem ?? throw new ArgumentNullException(nameof(fileSystem));
    }

    public Task GenerateAsync(ClassModel model)
    {
        throw new NotImplementedException();
    }
}

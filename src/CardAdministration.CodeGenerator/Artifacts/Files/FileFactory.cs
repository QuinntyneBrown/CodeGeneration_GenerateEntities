using CardAdministration.CodeGenerator.Models;
using Microsoft.Extensions.Logging;

namespace CardAdministration.CodeGenerator.Artifacts.Files;

public class FileFactory: IFileFactory
{
    private readonly ILogger<FileFactory> _logger;

    public FileFactory(ILogger<FileFactory> logger){
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<ClassModel> CreateSimpleType(SimpleType simpleType, string directory)
    {
        var model = new ClassModel(simpleType.Name, directory);

        return model;
    }
}


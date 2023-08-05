using CardAdministration.CodeGenerator.Models;
using Microsoft.Extensions.Logging;

namespace CardAdministration.CodeGenerator.Artifacts.Files;

public class FileFactory: IFileFactory
{
    private readonly ILogger<FileFactory> _logger;

    public FileFactory(ILogger<FileFactory> logger){
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<ClassModel> CreateSimpleType(SimpleType type, string directory)
    {
        var model = new ClassModel(type.Name, directory);

        return model;
    }

    public async Task<ClassModel> CreateComplexType(ComplexType type, string directory)
    {
        var model = new ClassModel(type.Name, directory);

        return model;
    }
}


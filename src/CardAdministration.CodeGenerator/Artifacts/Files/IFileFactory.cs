using CardAdministration.CodeGenerator.Models;

namespace CardAdministration.CodeGenerator.Artifacts.Files;

public interface IFileFactory
{
    Task<ClassModel> CreateSimpleType(SimpleType simpleType, string directory);

}


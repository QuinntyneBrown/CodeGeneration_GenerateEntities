using CardAdministration.CodeGenerator.Models;

namespace CardAdministration.CodeGenerator.Artifacts.Files;

public interface IFileFactory
{
    Task<ClassModel> CreateSimpleType(SimpleType type, string directory);

    Task<ClassModel> CreateComplexType(ComplexType type, string directory);

}


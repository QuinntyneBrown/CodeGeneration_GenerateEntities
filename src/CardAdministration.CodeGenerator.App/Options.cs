using CommandLine;

namespace CardAdministration.CodeGenerator.App;

public class Options
{
    [Option('p')]
    public required string Path { get; set; }

    [Option('o')]
    public required string OutputDirectory { get; set; } = "C:\\projects\\CodeGeneration_GenerateEntities\\src\\CardAdministration.Core\\";

    [Option('t')]
    public required string TemplateDirectory { get; set; } = "C:\\projects\\CodeGeneration_GenerateEntities\\src\\CardAdministration.CodeGenerator\\Templates\\";
}
using CommandLine;

namespace CardAdministration.CodeGenerator.App;

public class Options
{
    [Option('p')]
    public required string Path { get; set; }

    [Option('d')]
    public required string Directory { get; set; } = Environment.CurrentDirectory;
}
using CommandLine;

public class AppOptions
{
    [Option('p')]
    public string Path { get; set; }
}
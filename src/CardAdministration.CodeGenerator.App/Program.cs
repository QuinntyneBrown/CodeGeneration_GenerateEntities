using CardAdministration.CodeGenerator.App;
using CardAdministration.CodeGenerator.Artifacts;
using CardAdministration.CodeGenerator.Artifacts.Files;
using CardAdministration.CodeGenerator.Models;
using CommandLine;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

await RunAsync();

async Task RunAsync()
{
    var parsedResult = _createParser().ParseArguments<Options>(args);


    var host = Host.CreateDefaultBuilder().ConfigureServices(services =>
    {
        services.AddLogging();
        services.AddCodeGeneratorServices(x => {
            x.TemplatesDirectory = parsedResult.Value.TemplateDirectory;
            x.OutputDirectory = parsedResult.Value.OutputDirectory;
        });
    }).Build();

    var parser = host.Services.GetRequiredService<IConceptualModelParser>();

    var generator = host.Services.GetRequiredService<IArtifactGenerator>();

    var fileFactory = host.Services.GetRequiredService<IFileFactory>();

    var model = await parser.ParseAsync(parsedResult.Value.Path);

    foreach (var simpleType in model.SimpleTypes)
    {
        var fileModel = await fileFactory.CreateSimpleType(simpleType, parsedResult.Value.OutputDirectory);

        await generator.GenerateAsync(fileModel);
    }
}

Parser _createParser() => new Parser(with =>
{
    with.CaseSensitive = false;
    with.HelpWriter = Console.Out;
    with.IgnoreUnknownArguments = true;
});
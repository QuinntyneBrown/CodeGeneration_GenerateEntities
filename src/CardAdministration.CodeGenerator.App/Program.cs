using CardAdministration.CodeGenerator.Artifacts;
using CardAdministration.CodeGenerator.Models;
using CommandLine;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

await RunAsync();

async Task RunAsync()
{
    var host = Host.CreateDefaultBuilder().ConfigureServices(services =>
    {
        services.AddCodeGeneratorServices();
        services.AddAppServices();
    }).Build();

    var parser = host.Services.GetRequiredService<IConceptualModelParser>();

    var generator = host.Services.GetRequiredService<IArtifactGenerator>();

    var parsedResult = _createParser().ParseArguments<AppOptions>(args);

    var model = await parser.ParseAsync(parsedResult.Value.Path);

    foreach (var simpleType in model.SimpleTypes)
    {
        await generator.GenerateAsync(simpleType);
    }
}

Parser _createParser() => new Parser(with =>
{
    with.CaseSensitive = false;
    with.HelpWriter = Console.Out;
    with.IgnoreUnknownArguments = true;
});
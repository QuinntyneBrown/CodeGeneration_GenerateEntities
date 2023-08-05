using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CardAdministration.CodeGenerator.Artifacts;

public class ArtifactGenerator: IArtifactGenerator
{
    private readonly ILogger<ArtifactGenerator> _logger;
    private readonly IServiceProvider _serviceProvider;


    public ArtifactGenerator(ILogger<ArtifactGenerator> logger, IServiceProvider serviceProvider)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
    }

    public async Task GenerateAsync<T>(T model)
    {
        var strategy = _serviceProvider.GetService<IArtifactGenerationStrategy<T>>();

        if(strategy == null)
        {

        }

        await strategy!.GenerateAsync(model);

    }

}


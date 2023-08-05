using CardAdministration.CodeGenerator.Artifacts;
using CardAdministration.CodeGenerator.Artifacts.Files;
using CardAdministration.CodeGenerator.Models;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static void AddCodeGeneratorServices(this IServiceCollection services){ 
    
        services.AddSingleton<IConceptualModelParser, ConceptualModelParser>();
        services.AddSingleton<IArtifactGenerator , ArtifactGenerator>();
        services.AddSingleton<IArtifactGenerationStrategy<ClassModel>, ClassGenerationStrategy>();
    }

}


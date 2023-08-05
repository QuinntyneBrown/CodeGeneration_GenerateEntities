using CardAdministration.CodeGenerator;
using CardAdministration.CodeGenerator.Artifacts;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static void AddCodeGeneratorServices(this IServiceCollection services){ 
    
        services.AddSingleton<IArtifactGenerator , ArtifactGenerator>();
    }

}


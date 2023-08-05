using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CardAdministration.CodeGenerator.Artifacts;

public interface IArtifactGenerator
{
    Task GenerateAsync<T>(T model);

}


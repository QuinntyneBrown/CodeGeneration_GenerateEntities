namespace CardAdministration.CodeGenerator.Artifacts;

public interface IArtifactGenerationStrategy<T>
{
    Task GenerateAsync(T model);
}
namespace CardAdministration.CodeGenerator.Services;

public interface ITemplateProcessor
{
    Task<string> ProcessAsync<T>(T model);

}


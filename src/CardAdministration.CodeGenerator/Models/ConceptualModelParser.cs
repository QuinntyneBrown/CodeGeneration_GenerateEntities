using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CardAdministration.CodeGenerator.Models;

public class ConceptualModelParser: IConceptualModelParser
{
    private readonly ILogger<ConceptualModelParser> _logger;

    public ConceptualModelParser(ILogger<ConceptualModelParser> logger){
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<ConceptualModel> ParseAsync(string path)
    {
        _logger.LogInformation("DoWorkAsync");

        throw new NotImplementedException();
    }

}


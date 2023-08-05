using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CardAdministration.CodeGenerator.Models;

public interface IConceptualModelParser
{
    Task<ConceptualModel> ParseAsync(string path);

}


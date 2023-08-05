using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CardAdministration.CodeGenerator.Services;

public interface ITemplateProcessor
{
    Task DoWorkAsync();

}


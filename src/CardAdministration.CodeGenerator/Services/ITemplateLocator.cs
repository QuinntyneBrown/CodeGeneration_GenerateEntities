using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CardAdministration.CodeGenerator.Services;

public interface ITemplateLocator
{
    Task DoWorkAsync();

}


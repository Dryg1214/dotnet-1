﻿using Lab1.Services;
using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace Lab1.Commands
{
    public class ClearFunctionsCommand : Command<ClearFunctionsCommand.ClearFunctionsSettings>
    {
        public class ClearFunctionsSettings : CommandSettings
        {
        }

        private readonly IFunctionsRepository _functionsRepository;

        public ClearFunctionsCommand(IFunctionsRepository functionRepository)
        {
            _functionsRepository = functionRepository;
        }

        public override int Execute([NotNull] CommandContext context, [NotNull] ClearFunctionsSettings settings)
        {
            _functionsRepository.Clear();
            AnsiConsole.MarkupLine($"[green]The list of functions has been cleared[/]");
            return 0;
        }
    }
}

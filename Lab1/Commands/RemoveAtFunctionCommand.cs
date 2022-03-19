﻿using Lab1.Services;
using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace Lab1.Commands
{
    class RemoveAtFunctionCommand : Command<RemoveAtFunctionCommand.RemoveAtFunctionSettings>
    {
        public class RemoveAtFunctionSettings : CommandSettings
        {
        }

        private readonly IFunctionsRepository _functionsRepository;

        public RemoveAtFunctionCommand(IFunctionsRepository functionRepository)
        {
            _functionsRepository = functionRepository;
        }

        public override int Execute([NotNull] CommandContext context, [NotNull] RemoveAtFunctionSettings settings)
        {
            int index = AnsiConsole.Prompt(new TextPrompt<int>("[green]Enter the index of the function to be removed :[/]"));
            _functionsRepository.RemoveAt(index);
            return 0;
        }
    }
}

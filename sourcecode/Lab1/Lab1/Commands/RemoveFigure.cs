﻿using Lab1.Repository;
using Spectre.Console.Cli;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Commands
{
    public class RemoveFigure : Command<RemoveFigure.RemoveFigureCommand>
    {
        public class RemoveFigureCommand : CommandSettings
        {

        }
        private readonly IFigureRepository _figureRepository;
        public RemoveFigure(IFigureRepository figureRepo)
        {
            _figureRepository = figureRepo;
        }

        public override int Execute([NotNull] CommandContext context, [NotNull] RemoveFigureCommand settings)
        {
            Console.Write("Index = ");
            var index = AnsiConsole.Ask<int>("[green]Index = [/]");
            _figureRepository.RemoveFigure(index);
            return 0;
        }
    }
}

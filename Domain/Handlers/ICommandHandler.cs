using Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Handlers
{
    public interface ICommandHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}

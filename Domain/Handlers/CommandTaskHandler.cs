using Domain.Commands.Contracts;
using Domain.Commands.EntitiesCommands;
using Domain.Commands.EntitiesCommands.Tasks;
using Domain.Contracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Handlers
{
    public class CommandTaskHandler : ICommandHandler<CreateTaskCommand>
    {
        private readonly ITasksRepository _repository;

        public CommandTaskHandler(ITasksRepository repository)
        {
            _repository = repository;
        }


        public ICommandResult Handle(CreateTaskCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, parece que sua tarefa está errada!", command.Notifications);

            var todo = new Tasks(command.Title, command.Done, command.Date, command.Item);

            _repository.CreateTasks(todo);

            return new GenericCommandResult(true, "Tarefa salva", todo);
        }
    }
}

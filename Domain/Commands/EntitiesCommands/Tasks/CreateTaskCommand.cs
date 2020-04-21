using Domain.Commands.Contracts;
using Domain.Entities;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands.EntitiesCommands.Tasks
{
    public class CreateTaskCommand : Notifiable, ICommand
    {
        public CreateTaskCommand() { }

        public CreateTaskCommand(string title, bool done, DateTime date, Item item)
        {
            Title = title;
            Done = done;
            Date = date;
            Item = item;
        }


        public string Title { get; private set; }
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
        public Item Item { get; private set; }

        public void Validate()
        {
            AddNotifications(
                 new Contract()
                     .Requires()
                     .HasMinLen(Title, 3, "Title", "Por favor, descreva melhor esta tarefa!")
             );
        }
    }
}

using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Tasks: BaseEntity
    {
        protected Tasks() { }
        public Tasks(string title, bool done, DateTime date, Item item)
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
        public Guid ItemId { get; private set; }

        public void MarkAsDone() => Done = true;
        public void MarkAsUndone() => Done = false;
        public void UpdateTitle(string title) => Title = title;
    }
}

using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Item : BaseEntity
    {
        protected Item() { }
        public Item(string name, DateTime started, string description, User user)
        {
            Name = name;
            Started = started;
            Description = description;
            User = user;
        }

        public string Name { get; set; }
        public DateTime Started { get; set; }
        public DateTime? Ended { get; set; }
        public string Description { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; }

        public int TaskId { get; set; }
        public IList<Tasks> Tasks { get; set; }

        public void UpdateStartDate(DateTime date) => Started = date;
        public void UpdateEndDate(DateTime date) => Ended = date;
        public void UpdateDescription(string desc) => Description = desc;

        public IList<Tasks> GetTasks(Item item)
        {
            return item.Tasks;
        }

        public void AddTaskToItem(Tasks task)
        {
            if (User != null && Ended == null)
            {
                Tasks.Add(task);
            }
        }

    }
}

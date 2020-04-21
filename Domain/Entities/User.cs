using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        protected User() { }
        public User(string name, string job)
        {
            Name = name;
            Job = job;
        }

        public string Name { get; set; }
        public string Job { get; set; }

        public ICollection<Item> Items { get; set; }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}

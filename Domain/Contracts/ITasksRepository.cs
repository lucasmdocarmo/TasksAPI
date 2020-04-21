using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contracts
{
    public interface ITasksRepository : IRepository<Tasks>
    {
        void CreateTasks(Tasks todo);
        void UpdateTasks(Tasks todo);
        Tasks GetTasksById(Guid id, string user);
        IEnumerable<Tasks> GetAllTasks(string user);
        IEnumerable<Tasks> GetAllDoneTasks(string user);
        IEnumerable<Tasks> GetAllUndoneTasks(string user);
        IEnumerable<Tasks> GetTasksByPeriod(string user, DateTime date, bool done);
    }
}

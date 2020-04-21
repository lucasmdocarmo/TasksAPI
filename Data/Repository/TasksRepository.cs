using Data.Context;
using Domain.Contracts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class TasksRepository : Repository<Tasks>, ITasksRepository
    {
        public TasksRepository(ApplicationContext db) : base(db)
        {
        }


        public Task Add(Tasks entity)
        {
            throw new NotImplementedException();
        }

        public void CreateTasks(Tasks todo)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Tasks entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            DbContext?.Dispose();
        }

        public Task<List<Tasks>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tasks> GetAllDoneTasks(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tasks> GetAllTasks(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tasks> GetAllUndoneTasks(string user)
        {
            throw new NotImplementedException();
        }

        public Task<Tasks> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Tasks GetTasksById(Guid id, string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tasks> GetTasksByPeriod(string user, DateTime date, bool done)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tasks>> Search(Expression<Func<Tasks, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Update(Tasks entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateTasks(Tasks todo)
        {
            throw new NotImplementedException();
        }
    }
}

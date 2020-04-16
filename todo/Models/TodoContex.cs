using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo.Models
{
    public class TodoContex : DbContext
    {
        public TodoContex(DbContextOptions<TodoContex> options)
           : base(options)
        {
        }

        public DbSet<todoItem> TodoItems { get; set; }
        public DbSet<People> Peoples { get; set; }


        public IEnumerable<People> getPeopleWithOutTasks(IEnumerable<People> people)
        {
            return
                from peopleWithOutTasks in people
                where peopleWithOutTasks.countOfTodoItems == 0
                select peopleWithOutTasks;
        }
    }
}

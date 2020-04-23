using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace todo.Models
{
    public class People
    {
        public long id { get; set; }
        public string name { get; set; }
        public string birthDate { get; set; }

        public ICollection<todoItem> tasks { get; set; }

        public int getCountOfTodoItems()
        {
            return tasks.Count;
        }
    }
}

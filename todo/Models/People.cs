using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todo.Models
{
    public class People
    {
        public long id { get; set; }
        public string name { get; set; }
        public string birthDate { get; set; }
        public long countOfTodoItems { get; set; }

    }
}

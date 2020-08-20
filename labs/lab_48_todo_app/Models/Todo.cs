using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_48_todo_app.Models
{
    public class Todo
    {
        public int TodoId { get; set; }
        public string ToDoName { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }

    }
}

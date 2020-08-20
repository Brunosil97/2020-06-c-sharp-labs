using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_48_todo_app.Models
{
    public class User
    {
        public User()
        {
            Todos = new HashSet<Todo>();
        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Todo> Todos { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_48_todo_app.Models
{
    public class DisplayTodoWithUserName
    {
        public int id { get; set; }
        public string item { get; set; }
        public string username { get; set; }
    }
}

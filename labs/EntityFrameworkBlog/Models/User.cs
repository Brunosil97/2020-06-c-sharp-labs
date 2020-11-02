using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkBlog.Models
{
    public class User
    {
        public User()
        {
            Todos = new HashSet<ToDo>();
        }
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<ToDo> Todos { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EntityFrameworkBlog.Models
{
    public class ToDo
    {
        [Key]
        public int TodoId { get; set; }
        public string ToDoName { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
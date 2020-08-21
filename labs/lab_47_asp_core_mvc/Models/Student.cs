using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab_47_asp_core_mvc.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        [Display(Name = "Date OF Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-mm-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }
        public bool CurrentlyStudent { get; set; }
        public int CollegeId { get; set; }
        public College College { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppSchool.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name = "Имя")]
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        //public int NewProperty { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}

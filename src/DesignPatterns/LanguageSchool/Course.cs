﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LanguageSchool
{
    public class Course
    {
        public string Language { get; set; }
        public List<string> CourseBooks = new List<string>();
        public int Price { get; set; }
        public ICourseType Type { get; set; }
        public string Address { get; set; }

        private ICourseType courseType;

        public Course(ICourseType courseType = null)
        {
            this.courseType = courseType;
        }

        public void SetAddress()
        {
            Address = courseType.GetCourseAddress();
        }
    }
}

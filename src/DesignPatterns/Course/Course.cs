using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Course
    {
        public string Language { get; set; }
        public List<string> CourseBooks = new List<string>();
        public int Price { get; set; }
    }
}

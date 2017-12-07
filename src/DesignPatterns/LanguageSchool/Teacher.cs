using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LanguageSchool
{
    public class Teacher
    {
        public string Name { get; set; }

        private List<IStudent> students = new List<IStudent>();

        public void addStudent(IStudent student)
        {
            if (!students.Contains(student))
            {
                students.Add(student);
            }

        }

        public void removeStudent(IStudent student)
        {
            if (students.Contains(student))
            {
                students.Remove(student);
            }
        }

        public void BeginExcercise()
        {
            foreach (IStudent student in students)
            {
                student.Update();
            }
        }
    }
}

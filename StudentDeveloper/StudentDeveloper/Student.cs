using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StudentDeveloper
{
    public class Student
    {
        // Fields or Properties or Variables 
        public int StudyHoursPerWeek { get; set; }
        public int StudyWeeksCompleted { get; set; }
        public string NameOfStudent { get; set; }

        // For the output
        public string OutputStorage { get; set; }   

        // Functions or Methods or Behaviours or Actions
        public void BuildStudentInformation()
        {
            this.OutputStorage = $"Student Name: {this.NameOfStudent} " +
                $"Study Hours: {this.StudyHoursPerWeek}" +
                $" Number of Weeks Completed: {this.StudyWeeksCompleted}";
        }

        public void DisplayStudentInformation()
        {
            Console.WriteLine(this.OutputStorage);
        }
    }
}

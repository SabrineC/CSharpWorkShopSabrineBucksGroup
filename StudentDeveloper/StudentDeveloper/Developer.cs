using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDeveloper
{
    public class Developer
    {
        // Constructor to assign default values
        public Developer()
        {
            Console.WriteLine("Hey guys this constructor has been called");

            this.TotalNumberOfHoursToBecomeDeveloper = 500;
        }

        // Fields or Properties for this class
        public int TotalNumberOfHoursToBecomeDeveloper { get; set; }
        public string outputForStudent { get; set; }

        public void CalculateDeveloperEstimate(int StudyHoursPerWeek, int StudyWeeksCompleted, string NameOfStudent)
        {
            int numberOfWeeksBasedOnStudentWeeklyHoursCommitment = TotalNumberOfHoursToBecomeDeveloper / StudyHoursPerWeek;

            int remainingNumberOfWeeksToStudy = numberOfWeeksBasedOnStudentWeeklyHoursCommitment - StudyWeeksCompleted;

            // Display as number of months
            int numberofMonths = 0;

            while (remainingNumberOfWeeksToStudy > 4)
            {
                numberofMonths = numberofMonths + 1;
                remainingNumberOfWeeksToStudy = remainingNumberOfWeeksToStudy - 4;
            }

            this.outputForStudent = $"{NameOfStudent} will need to study for {numberofMonths} months to become a basic beginner developer";

        }

        public void DisplayDeveloperEstimate()
        {
            Console.WriteLine(this.outputForStudent);
        }
    }
}

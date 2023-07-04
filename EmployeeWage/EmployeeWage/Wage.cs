using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Wage
    {
        public Wage()
        {
        }
        public string outputForEmployee { get; set; }

        public void CalculateWage(int WorkHoursPerWeek, int WorkPayPerHour, string NameOfEmployee)
        {
            // Calculate wage total
            int TotalWage = WorkHoursPerWeek * WorkPayPerHour;


            this.outputForEmployee = $"{NameOfEmployee} works {WorkHoursPerWeek} hours per week and earns £{TotalWage}";

        }

        public void DisplayWage()
        {
            Console.WriteLine(this.outputForEmployee);
        }
    }
}

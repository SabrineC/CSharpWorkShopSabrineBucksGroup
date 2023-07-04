using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class Employee
    {
        // Variables 
        public int WorkHoursPerWeek { get; set; }
        public int WorkPayPerHour { get; set; }
        public string NameOfEmployee { get; set; }

        // For the output
        public string OutputStorage { get; set; }

        // Functions
        public void BuildEmployeeInformation()
        {
            this.OutputStorage = $"Employee Name: {this.NameOfEmployee} " +
                $"Work Hours: {this.WorkHoursPerWeek} " +
                $"Pay per Hour: {this.WorkPayPerHour}";
        }

        public void DisplayEmployeeInformation()
        {
            Console.WriteLine(this.OutputStorage);
        }
    }
}

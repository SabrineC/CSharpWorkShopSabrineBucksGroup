using EmployeeWage;

// Employee John

Employee John = new Employee();
John.NameOfEmployee = "John";
John.WorkHoursPerWeek = 30;
John.WorkPayPerHour = 10;

John.BuildEmployeeInformation();
John.DisplayEmployeeInformation();

// Using the Wage Class
Wage WageShow = new Wage();

WageShow.CalculateWage(John.WorkHoursPerWeek, John.WorkPayPerHour, John.NameOfEmployee);
WageShow.DisplayWage();

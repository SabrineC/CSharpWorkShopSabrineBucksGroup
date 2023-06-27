// See https://aka.ms/new-console-template for more information

using StudentDeveloper;

// Student called Bruce Wayne
Student BruceWayne = new Student();
// Student called Selina Kyle
Student SelinaKyle = new Student();

BruceWayne.NameOfStudent = "Bruce Wayne";
BruceWayne.StudyHoursPerWeek = 20;
BruceWayne.StudyWeeksCompleted = 0;

BruceWayne.BuildStudentInformation();
BruceWayne.DisplayStudentInformation();

SelinaKyle.NameOfStudent = "Selina Kyle";
SelinaKyle.StudyHoursPerWeek = 10;
SelinaKyle.StudyWeeksCompleted = 10;

SelinaKyle.BuildStudentInformation();
SelinaKyle.DisplayStudentInformation();

#region
//string outputForBatman = $"Student Name: {BruceWayne.NameOfStudent}" +
//    $" Study Hours: {BruceWayne.StudyHoursPerWeek}" +
//    $" Number of Weeks Completed: {BruceWayne.StudyWeeksCompleted}";
//string outputForCatwoman = $"Student Name: {SelinaKyle.NameOfStudent} " +
//    $" Study Hours: {SelinaKyle.StudyHoursPerWeek}" +
//    $" Number of Weeks Completed: {SelinaKyle.StudyWeeksCompleted}";

//Console.WriteLine(outputForBatman);
//Console.WriteLine(outputForCatwoman);

#endregion

// Super Hero called The Phantom
Student KitWalker = new Student();
KitWalker.NameOfStudent = "Kit Walker";
KitWalker.StudyHoursPerWeek = 30;
KitWalker.StudyWeeksCompleted = 30;

KitWalker.BuildStudentInformation();
KitWalker.DisplayStudentInformation();

// 500 hours is the amount of time it takes to become
// a beginner developer

int TotalNumberOfHoursToBecomeDeveloper = 500;

// 20 hours per week
// 25 weeks to become a beginner developer
// Number of weeks already completed is 0
// Remaining weeks = 25 - 0 = 25 weeks
// Ultimatley, Batman will become a developer in 25 weeks

// 10 hours per week
// 50 weeks to become a beginner developer
// Number of weeks already completed is 10
// Remaining weeks = 50 - 10 = 40 weeks
// Eventually, Catwoman will become a develoepr in 40 weeks
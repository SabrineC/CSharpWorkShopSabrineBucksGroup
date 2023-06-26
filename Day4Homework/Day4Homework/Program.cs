//Create a project that will
//A simple class
//class should have at least 5 properties
//then, use this class to create at least 3 objects in Program.cs
//build an output with the values stored in these 3 objects
//Bonus : see if you can build a function/behavior that will take care of the output from within the class itself.

using Day4Homework;

//First person
Person firstperson = new Person();
firstperson.Name = "John";
firstperson.Age = 35;
firstperson.Gender = "Male";
firstperson.Location = "America";
firstperson.Birthday = "1st January";

string firstpersonoutput = $"Name: {firstperson.Name}" +
    $" Age: {firstperson.Age}" +
    $" Gender: {firstperson.Gender}" +
    $" Location: {firstperson.Location}" +
    $" Birthday: {firstperson.Birthday}";

Console.WriteLine(firstpersonoutput);

//Second person
Person secondperson = new Person();
secondperson.Name = "Sam";
secondperson.Age = 23;
secondperson.Gender = "Male";
secondperson.Location = "United Kingdom";
secondperson.Birthday = "15th May";

string secondpersonoutput = $"Name: {secondperson.Name}" +
    $" Age: {secondperson.Age}" +
    $" Gender: {secondperson.Gender}" +
    $" Location: {secondperson.Location}" +
    $" Birthday: {secondperson.Birthday}";

Console.WriteLine(secondpersonoutput);

//Third person
Person thirdperson = new Person();
thirdperson.Name = "Katie";
thirdperson.Age = 19;
thirdperson.Gender = "Female";
thirdperson.Location = "Australia";
thirdperson.Birthday = "26th June";

string thirdpersonoutput = $"Name: {thirdperson.Name}" +
    $" Age: {thirdperson.Age}" +
    $" Gender: {thirdperson.Gender}" +
    $" Location: {thirdperson.Location}" +
    $" Birthday: {thirdperson.Birthday}";

Console.WriteLine(thirdpersonoutput);
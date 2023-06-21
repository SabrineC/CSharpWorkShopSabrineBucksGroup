//Create a project that has the following things
//A simple function
//that takes in 4 integer parameters/arguments/variables
//adds all these parameters using the addition operator
//returns the result
//call this function, and collect the result
//build a string output with all 4 integer parameters and the result
//display the output using console writeline

// Variable Definition
int numberOne = 5;
int numberTwo = 10;
int numberThree = 15;
int numberFour = 20;

//Function Definition
int AddFourNumbers(int num1, int num2, int num3, int num4)
{
    int sum = num1 + num2 + num3 + num4;
    return sum;
}

//Functional Calling
int storeResult = AddFourNumbers(numberOne, numberTwo, numberThree, numberFour);
string fancyOutput = $"{numberOne} + {numberTwo} + {numberThree} + {numberFour} = {storeResult}";
Console.WriteLine(fancyOutput);
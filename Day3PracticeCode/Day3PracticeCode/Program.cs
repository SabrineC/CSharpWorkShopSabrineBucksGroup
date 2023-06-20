// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Type One
//function that doesnt take any arguments nor return a value
void FunctionTypeOne() {
    string someString1 = "Hey guys, the Flash movie is not that good";
    Console.WriteLine(someString1);
}

//function call
FunctionTypeOne();

//Type TwoPartA
//function that will take a single parameter but does not return a value

void FunctionTypeTwo(int numberofmovies)
{
    string outputSentence = $"I have watched {numberofmovies} movies this year";
    Console.WriteLine(outputSentence);
}

int toBeSentToFunctionMovieCount = 200;
FunctionTypeTwo(toBeSentToFunctionMovieCount);
FunctionTypeTwo(10);

//Type TwoPartB
//similar to TypeTwo but with more than one parameter

void FunctionTypeTwoPartB(int one, string two, bool three)
{
    string someOutput = $"The values are {one}, {two}, {three}";
    Console.WriteLine(someOutput);
}

int one = 1;
string two = "two";
bool three = true;

FunctionTypeTwoPartB(one, two, three);

//TypeThree
//function that is taking some paramters and returning some value

//function that will add two numbers
int FunctionThatAddsTwoNumbers (int numberOne, int numberTwo) {
    int sum = numberOne + numberTwo;
    return sum;
}

int doubleoseven = 7;
int randomagent = 50;

//function call
int result = FunctionThatAddsTwoNumbers(doubleoseven, randomagent);

string outputofAgents = $"The sum of {doubleoseven} and {randomagent} is {result}";
Console.WriteLine(outputofAgents);

//Type Four
//function that is NOT taking any parameters but returns a value

int FunctionThatReturnsRandomNumber()
{
    Random random = new Random();
    int randomNumber = random.Next(1, 100);
    return randomNumber;
}

int FunctionThatReturnsRandomNumber2(int lowerbound, int upperbound)
{
    Random random = new Random();
    int randomNumber = random.Next(lowerbound, upperbound);
    return randomNumber;
}

int randomnumber = FunctionThatReturnsRandomNumber();
string somerandomsentence = $"The random number is {randomnumber} between 1 and 100, no parameters are sent";

Console.WriteLine(somerandomsentence);

int lowerboundvalue = 500;
int upperboundvalue = 800;
int randomnumber2 = FunctionThatReturnsRandomNumber2(500, 800);
string somerandomsentence2 = $"The random number is {randomnumber2} between {lowerboundvalue} and {upperboundvalue}, no parameters are sent";

Console.WriteLine(somerandomsentence2);

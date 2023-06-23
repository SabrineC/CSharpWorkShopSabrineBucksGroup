//Create a project that will
//one single function that takes two parameters
//then, that single function should in turn call four separate functions
//each of these functions are about : addition, subtraction, division and multiplication
//Then, show the result inside the first, single function
//Bonus : check for 'divide by zero' in the division function using if else

# region variable declarations
using System.Diagnostics;

int number1 = 5;
int number2 = 0;
# endregion

# region function calling
void calculate(int num1, int num2)
{
    int sum = Add(number1, number2);
    Console.WriteLine($"The sum of {number1} and {number2} is {sum}");

    int difference = Subtract(number1, number2);
    Console.WriteLine($"The difference of {number1} and {number2} is {difference}");

    int product = Multiply(number1, number2);
    Console.WriteLine($"The product of {number1} and {number2} is {product}");

    int quotient = Divide(number1, number2);
    Console.WriteLine($"The quotient of {number1} and {number2} is {quotient}");
}
#endregion

# region function definitions
int Add(int num1, int num2)
{
    int result = num1 + num2;
    return result;
}

int Subtract(int num1, int num2)
{
    int difference = num1 - num2;
    return difference;
}

int Multiply(int num1, int num2)
{
    int product = num1 * num2;
    return product;
}

int Divide(int num1, int num2)
{
    if (num2 == 0)
    {
        Console.WriteLine("Divide by zero");
        return 0;
    }
    else
    {
        int quotient = num1 / num2;
        return quotient;
    }
}
# endregion

calculate(number1, number2);
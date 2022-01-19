// an import statement that makes calling the functions a little less wordy
using static Calculator.Functions;

Console.WriteLine("Welcome to the Harrington™ calculator!");

// loop forever, until the return command is run
while (true)
{
    // Show the options
    Console.WriteLine("\t1. Add");
    Console.WriteLine("\t2. Subtract");
    Console.WriteLine("\t3. Multiply");
    Console.WriteLine("\t4. Divide");
    Console.WriteLine("\t0. Exit");

    // Prompt the user to enter the option
    int input = GetUserInputAsInteger("Choose an option and press enter: ");

    if (input == 0)
    {
        // the break command will cause the program to exit from the loop immediately
        break;
    }


    // if we get to here, that means the user didn't choose the exit option
    // so ask for two numbers
    int firstNumber = GetUserInputAsInteger("Enter the first number and press enter: ");
    int secondNumber = GetUserInputAsInteger("Enter the second number and press enter: ");

    // choose the correct action based on the user's choice and print the answer
    if (input == 1)
    {
        int sum = Add(firstNumber, secondNumber);
        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} equals {sum}");
    }
    else if (input == 2)
    {
        int diff = Subtract(firstNumber, secondNumber);
        Console.WriteLine($"The difference of {firstNumber} and {secondNumber} equals {diff}");
    }
    else if (input == 3)
    {
        int product = Multiply(firstNumber, secondNumber);
        Console.WriteLine($"The product of {firstNumber} and {secondNumber} equals {product}");
    }
    else if (input == 4)
    {
        double quotient = Divide(firstNumber, secondNumber);
        Console.WriteLine($"The quotient of {firstNumber} over {secondNumber} equals {quotient:F2}");
    }

    // write out two newlines as a separator
    Console.Write("\n\n");
}

Console.WriteLine("Goodbye!");


/* Function Definitions */


// Asks the user for input, using the prompt parameter as a message to the user,
// and returns the integer value of the user input
static int GetUserInputAsInteger(string prompt)
{
    // this variable will store whether the user input is a valid integer
    bool isValidInteger = false;

    // declare an integer variable that will hold the integral value of the user input
    int inputInteger = 0;

    // loop until isValidInteger is true
    while (!isValidInteger)
    {
        // print out the prompt
        Console.Write(prompt);

        // store the user's input into the string variable called "input"
        string input = Console.ReadLine();

        // the following line will attempt to convert the user input to an integer,
        // and store it in an integer variable called "inputInteger"
        // it will also update the value of isValidInteger based on whether the conversion succeeded
        isValidInteger = int.TryParse(input, out inputInteger);

        // print out an error message if the conversion was not successful
        if (!isValidInteger)
        {
            Console.WriteLine("\nThat's not an integer, fool! Try again!");
        }
    }

    // if we've exited the while loop, that means we got a valid integer that this function can return
    return inputInteger;
}
